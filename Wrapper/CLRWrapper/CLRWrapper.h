#pragma once

#include "D:\Eighth Semester\Wrapper\OpenCVWrapper\OpenCVWrapper.h"
#include "D:\Eighth Semester\Wrapper\OpenCVWrapper\OpenCVWrapper.cpp"

using namespace System;
using namespace System::Runtime::InteropServices;

namespace MYopencv {
	/*public ref class MYConversion
	{
	public:
		MYConversion();
		char* myStringToChar(String^ str);
	};*/

	public ref class MYGui
	{
	public:
		//MYGui();
		//int myLoadAndShowRGB(String^ url, int maxWidth, int maxHeight, int nPicPerRow);
		void process();

		void por();

	private:
		MYcppGui *myGui;
	};
}