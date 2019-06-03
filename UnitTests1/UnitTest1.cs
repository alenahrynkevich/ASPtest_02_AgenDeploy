using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string valueString = "Your string1";
            Console.WriteLine(valueString);

        }

        [TestMethod]
        public void TestMethod2()
        {
            string valueString = "Running FAILING tests";
            Console.WriteLine(valueString);
            Assert.AreEqual("bla", "bla bla", false, "Check failed!");
        }


    }
}
