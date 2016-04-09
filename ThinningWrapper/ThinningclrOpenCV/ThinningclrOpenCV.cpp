// This is the main DLL file.

#include "stdafx.h"

#include "ThinningclrOpenCV.h"

#include <opencv2/opencv.hpp>
#include <opencv2/highgui/highgui.hpp>

#include "D:\Eighth Semester\ThinningWrapper\ThinningWrapper\cppOpenCV.h";
#include "D:\Eighth Semester\ThinningWrapper\ThinningWrapper\cppOpenCV.cpp"
using namespace ThinningProcess;

using namespace cv;

void thinningIteration(Mat& img, int iter);

void ThinningOpenCVWrapper::process()
{
	Mat sourceimage = imread("D:/Eighth Semester/HandVeinPattern/RuntimeDirectory/MultipliedImage.jpg", IMREAD_GRAYSCALE);

	Mat thinnedimage;

	/*cvtColor(sourceimage, thinnedimage, CV_BGR2GRAY);

	threshold(thinnedimage, thinnedimage, 10, 255, CV_THRESH_BINARY);*/

	Mat destination = sourceimage.clone();

	destination /= 255;         // convert to binary image

	Mat previous = Mat::zeros(destination.size(), CV_8UC1);
	
	Mat difference;

	do
	{
		thinningIteration(destination, 0);

		thinningIteration(destination, 1);

		absdiff(destination, previous, difference);

		destination.copyTo(previous);

	}
	while (countNonZero(difference) > 0);

	destination *= 255;

	thinnedimage = destination;


	// Find contours
	vector<vector<Point>> contours;
	findContours(thinnedimage.clone(), contours, RETR_EXTERNAL, CHAIN_APPROX_NONE, Point(-1, -1)); // Point(-1,-1) accounts for previous copyMakeBorder

	// Keep largest contour
	int size_largest = 0;
	int idx_largest = -1;
	for (int i = 0; i < contours.size(); ++i)
	{
		if (contours[i].size() > size_largest)
		{
			size_largest = contours[i].size();
			idx_largest = i;
		}
	}

	Mat3b dbg;
	cvtColor(thinnedimage, dbg, COLOR_GRAY2BGR);

	// Black initialized mask
	Mat1b thinnedmask(sourceimage.rows, sourceimage.cols, uchar(0));

	if (idx_largest >= 0)
	{
		drawContours(dbg, contours, idx_largest, Scalar(0, 255, 0), CV_FILLED);

		// Draw filled polygin on mask
		drawContours(thinnedmask, contours, idx_largest, Scalar(255), 1);
	}

	// Get a point inside the contour
	Moments m = moments(contours[idx_largest]);
	Point2f inside(m.m10 / m.m00, m.m01 / m.m00);

	floodFill(thinnedmask, inside, Scalar(!127));

	imwrite("D:/Eighth Semester/HandVeinPattern/RuntimeDirectory/ThinnedImage.jpg", thinnedmask);
}


void thinningIteration(Mat& img, int iter)
{
	CV_Assert(img.channels() == 1);
	CV_Assert(img.depth() != sizeof(uchar));
	CV_Assert(img.rows > 3 && img.cols > 3);

	Mat marker = Mat::zeros(img.size(), CV_8UC1);

	int nRows = img.rows;
	int nCols = img.cols;

	if (img.isContinuous()) {
		nCols *= nRows;
		nRows = 1;
	}

	int x, y;
	uchar *pAbove;
	uchar *pCurr;
	uchar *pBelow;
	uchar *nw, *no, *ne;    // north (pAbove)
	uchar *we, *me, *ea;
	uchar *sw, *so, *se;    // south (pBelow)

	uchar *pDst;

	// initialize row pointers
	pAbove = NULL;
	pCurr = img.ptr<uchar>(0);
	pBelow = img.ptr<uchar>(1);

	for (y = 1; y < img.rows - 1; ++y) {
		// shift the rows up by one
		pAbove = pCurr;
		pCurr = pBelow;
		pBelow = img.ptr<uchar>(y + 1);

		pDst = marker.ptr<uchar>(y);

		// initialize col pointers
		no = &(pAbove[0]);
		ne = &(pAbove[1]);
		me = &(pCurr[0]);
		ea = &(pCurr[1]);
		so = &(pBelow[0]);
		se = &(pBelow[1]);

		for (x = 1; x < img.cols - 1; ++x) {
			// shift col pointers left by one (scan left to right)
			nw = no;
			no = ne;
			ne = &(pAbove[x + 1]);
			we = me;
			me = ea;
			ea = &(pCurr[x + 1]);
			sw = so;
			so = se;
			se = &(pBelow[x + 1]);

			int A = (*no == 0 && *ne == 1) + (*ne == 0 && *ea == 1) +
				(*ea == 0 && *se == 1) + (*se == 0 && *so == 1) +
				(*so == 0 && *sw == 1) + (*sw == 0 && *we == 1) +
				(*we == 0 && *nw == 1) + (*nw == 0 && *no == 1);
			int B = *no + *ne + *ea + *se + *so + *sw + *we + *nw;
			int m1 = iter == 0 ? (*no * *ea * *so) : (*no * *ea * *we);
			int m2 = iter == 0 ? (*ea * *so * *we) : (*no * *so * *we);

			if (A == 1 && (B >= 2 && B <= 6) && m1 == 0 && m2 == 0)
				pDst[x] = 1;
		}
	}

	img &= ~marker;
}