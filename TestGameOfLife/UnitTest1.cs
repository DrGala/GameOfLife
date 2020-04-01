using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGameOfLife
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCanRenderANullGameBoard()
        {
            Assert.AreEqual(1, 2);
        }
    }
}