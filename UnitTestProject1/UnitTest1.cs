using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             Manager manager = new Manager();
                int count = manager.maxOrdersDays();
                Assert.AreEqual(100, count);
        }
    }
}
