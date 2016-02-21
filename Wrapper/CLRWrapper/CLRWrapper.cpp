// This is the main DLL file.
#include "stdafx.h"
#include "CLRWrapper.h"

#include <opencv2/opencv.hpp>
#include <opencv2/highgui/highgui.hpp>


#include "D:\Eighth Semester\Wrapper\OpenCVWrapper\OpenCVWrapper.h"
#include "D:\Eighth Semester\Wrapper\OpenCVWrapper\OpenCVWrapper.cpp"
using namespace MYopencv;

//using namespace std;
using namespace cv;

// ++++++++++++ MYGui Class ++++++++++++

//MYGui::MYGui()
//{
//	myGui = new MYcppGui();
//}

//int MYGui::myLoadAndShowRGB(String^ url, int maxWidth, int maxHeight, int nPicPerRow)
//{
//	MYConversion ^convert = gcnew MYConversion();
//	char* str = convert->myStringToChar(url);
//
//	int result = myGui->myCppLoadAndShowRGB(str, maxWidth, maxHeight, nPicPerRow);
//
//	// Add the line below will cause runtime assertion error (sth about heap error) in C#
//	//free(str);   
//	
//	return result;
//}

void MYGui::process()
{
	//// Load grayscale image

	//Mat1b sourceimage = imread("D:/Eighth Semester/HVPC/AdaptiveThreshold.jpg", IMREAD_GRAYSCALE);
	//
	//// Get rid of JPEG compression artifacts
	//
	//sourceimage = sourceimage > 100;

	//// Needed so findContours handles borders contours correctly
	//
	//Mat1b border;
	//
	//copyMakeBorder(sourceimage, border, 1, 1, 1, 1, BORDER_CONSTANT, 0);

	//// Apply morphological operation "close"

	//Mat1b closed;

	//Mat kernel = getStructuringElement(MORPH_ELLIPSE, Size(3, 3));

	//morphologyEx(border, closed, MORPH_OPEN, kernel);

	//// Find contours

	//vector<vector<Point>> contours;

	//findContours(border.clone(), contours, RETR_EXTERNAL, CHAIN_APPROX_NONE, Point(-1, -1)); // Point(-1,-1) accounts for previous copyMakeBorder

	//// Keep largest contour

	//int size_largest = 0;

	//int idx_largest = -1;

	//for (int i = 0; i < contours.size(); ++i)
	//{
	//	if (contours[i].size() > size_largest)
	//	{
	//		size_largest = contours[i].size();

	//		idx_largest = i;
	//	}
	//}

	//Mat3b dbg;

	//cvtColor(closed, dbg, COLOR_GRAY2BGR);


	//// Black initialized mask

	//Mat1b mask(sourceimage.rows, sourceimage.cols, uchar(0));

	//if (idx_largest >= 0)
	//{
	//	drawContours(dbg, contours, idx_largest, Scalar(0, 255, 0), CV_FILLED);

	//	// Draw filled polygin on mask

	//	drawContours(mask, contours, idx_largest, Scalar(255), 1);
	//}

	//// Get a point inside the contour

	//Moments m = moments(contours[idx_largest]);

	//Point2f inside(m.m10 / m.m00, m.m01 / m.m00);

	//floodFill(mask, inside, Scalar(127));

	//Mat3b result;

	//cvtColor(sourceimage, result, COLOR_GRAY2BGR);

	//result.setTo(Scalar(0), mask != 127);

	//imwrite("D:/Eighth Semester/HVPC/ResultImage.jpg", result);

	//return 0;
}

void MYGui::por()
{
	Mat1b sourceimage = imread("D:/Eighth Semester/HVP/RuntimeDirectory/AdaptiveThreshold.jpg", IMREAD_GRAYSCALE);

	// Get rid of JPEG compression artifacts

	sourceimage = sourceimage > 100;

	// Needed so findContours handles borders contours correctly
	
	Mat1b border;
	
	copyMakeBorder(sourceimage, border, 1, 1, 1, 1, BORDER_CONSTANT, 0);

	// Apply morphological operation "close"

	Mat1b closed;

	Mat kernel = getStructuringElement(MORPH_ELLIPSE, Size(3, 3));

	morphologyEx(border, closed, MORPH_OPEN, kernel);

	// Find contours

	vector<vector<Point>> contours;

	findContours(border.clone(), contours, RETR_EXTERNAL, CHAIN_APPROX_NONE, Point(-1, -1)); // Point(-1,-1) accounts for previous copyMakeBorder

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

	Mat3b result;

	cvtColor(sourceimage, result, COLOR_GRAY2BGR);

	result.setTo(Scalar(0), mask != 127);

	imwrite("D:/Eighth Semester/HVP/RuntimeDirectory/ResultImage.jpg", result);

}

// ++++++++++++ MYConversion Class ++++++++++++ 

//MYConversion::MYConversion() {}
//
//char* MYConversion::myStringToChar(String^ str)
//{
//	IntPtr ptr = Marshal::StringToHGlobalAnsi(str);
//	return static_cast<char*>(ptr.ToPointer());
//}