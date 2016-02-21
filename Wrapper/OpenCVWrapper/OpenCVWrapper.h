#pragma once
#include <opencv2/opencv.hpp>
#include <opencv2/highgui/highgui.hpp>

class MYcppGui {
public:
	/*MYcppGui();
	~MYcppGui();*/

	//int myCppLoadAndShowRGB(char* url, int maxWidth, int maxHeight, int nPicPerRow);

	void process();

	void por();

private:
	bool win0; // status of an OpenCV window
};