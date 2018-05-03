using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CS.Problems.Tests.DynamicProgramming
{
    [TestClass]
    public class StringInterleaving_Tests
    {
        [TestMethod]
        public void StringInterleaving_Smoke_Test()
        {
            Assert.IsTrue(StringInterleaving.IsInterleaved("aabcc", "dbbca", "aadbbcbcac"));
            Assert.IsTrue(StringInterleaving.IsInterleaved( "XY", "WZ", "WZXY"));

            Assert.IsFalse(StringInterleaving.IsInterleaved("ccbaa", "dbbca", "aadbbcbcac"));
            Assert.IsFalse(StringInterleaving.IsInterleaved("YZ", "WZ", "WZXY"));
        }
    }
}
