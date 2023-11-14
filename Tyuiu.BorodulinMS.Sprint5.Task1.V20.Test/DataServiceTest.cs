using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BorodulinMS.Sprint5.Task1.V20.Lib;
namespace Tyuiu.BorodulinMS.Sprint5.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\motya\source\repos\Tyuiu.BorodulinMS.Sprint5\Tyuiu.BorodulinMS.Sprint5.Task1.V20\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
