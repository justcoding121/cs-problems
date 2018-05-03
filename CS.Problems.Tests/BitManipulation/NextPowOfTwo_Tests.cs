using CS.Problems.BitManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CS.Problems.Tests.Binary
{

    [TestClass]
    public class NextPowOfTwo_Tests
    {
        [TestMethod]
        public void NextPowOfTwo_Smoke_Test()
        {
            Assert.AreEqual(8, NextPowOfTwo.Next(5));
        }
    }
}
