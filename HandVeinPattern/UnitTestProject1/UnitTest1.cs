using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using HandVeinPattern;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\JUNAID SULTAN\Desktop\User1.bmp";
            LoginForm loginform = new LoginForm();
            ImageMatching imagematching = new ImageMatching();
            Assert.AreEqual(1, imagematching.matchtest());
        }
    }
}
