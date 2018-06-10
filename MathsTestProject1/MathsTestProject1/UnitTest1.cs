using System;
using MathsComponentNameSpace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathsTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestSubstract()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Sub(20, 10);
            Assert.AreEqual(10, result);
        }
    }
}
