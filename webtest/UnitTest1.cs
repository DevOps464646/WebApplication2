using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace webtest
{
    [TestClass]
    public class DemoTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.IsTrue(result, "Value should be equal to 1")
        }
    }
}
