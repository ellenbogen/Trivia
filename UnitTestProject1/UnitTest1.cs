using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UglyTrivia;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Game c  = new Game();
            Assert.IsFalse(c.isPlayable());
        }
    }
}
