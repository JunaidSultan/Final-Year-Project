// This is the main DLL file.

#include "stdafx.h"

#include "clrOpenCV.h"

#include <opencv2/opencv.hpp>
#include <opencv2/highgui/highgui.hpp>

#include "D:\Eighth Semester\Wrapper\Wrapper\cppOpenCV.h";
#include "D:\Eighth Semester\Wrapper\Wrapper\cppOpenCV.cpp";

using namespace Wrapper;

using namespace cv;


void OpenCVWrapper::process()
{
	// Load grayscale image
	Mat1b sourceimage = imread("D:/Eighth Semester/HandVeinPattern/RuntimeDirectory/AdaptiveThreshold.jpg", IMREAD_GRAYSCALE);

	// Get rid of JPEG compression artifacts
	sourceimage = sourceimage > 100;

	// Needed so findContours handles borders contours correctly
	Mat1b bin;
	copyMakeBorder(sourceimage, bin, 1, 1, 1, 1, BORDER_CONSTANT, 0);

	// Apply morphological operation "close"
	Mat1b closed;
	Mat kernel = getStructuringElement(MORPH_ELLIPSE, Size(3, 3));
	morphologyEx(bin, closed, MORPH_OPEN, kernel);

	// Find contours
	vector<vector<Point>> contours;
	findContours(bin.clone(), contours, RETR_EXTERNAL, CHAIN_APPROX_NONE, Point(-1, -1)); // Point(-1,-1) accounts for previous copyMakeBorder

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
	cvtColor(closed, dbg, COLOR_GRAY2BGR);


	// Black initialized mask
	Mat1b mask(sourceimage.rows, sourceimage.cols, uchar(0));

	if (idx_largest >= 0)
	{
		drawContours(dbg, contours, idx_largest, Scalar(0, 255, 0), CV_FILLED);

		// Draw filled polygin on mask
		drawContours(mask, contours, idx_largest, Scalar(255), 1);
	}

	// Get a point inside the contour
	Moments m = moments(contours[idx_largest]);
	Point2f inside(m.m10 / m.m00, m.m01 / m.m00);

	floodFill(mask, inside, Scalar(127));

	Mat1b newmask = (mask == 127);
	
	imwrite("D:/Eighth Semester/HandVeinPattern/RuntimeDirectory/ResultImage.jpg", newmask);
}
