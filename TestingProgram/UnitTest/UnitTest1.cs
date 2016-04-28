using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = TestingProgram.Operations.Add(2,3.5);
            Assert.IsTrue(result == 5.5);
            var result2 = TestingProgram.Operations.Subtract(1, 3);
            Assert.IsTrue(result2 == -2);
        }
    }
}
