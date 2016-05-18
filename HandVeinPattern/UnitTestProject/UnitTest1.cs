using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HandVeinPattern;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ImageMatching im = new ImageMatching();
            string path = @"C:\Users\JUNAID SULTAN\Desktop\Junaid.bmp";
            im.testmethod(path);
            Assert.AreEqual(0, im.matchtest());
        }
    }
}
