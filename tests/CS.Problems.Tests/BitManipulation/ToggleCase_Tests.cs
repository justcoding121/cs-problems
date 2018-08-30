using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS.Problems.BitManipulation;

namespace CS.Problems.Tests.Binary
{
    [TestClass]
    public class ToggleCase_Tests
    {
        [TestMethod]
        public void ToggleCase_Smoke_Test()
        {
            Assert.AreEqual("HELLO", ToggleCase.Toggle("hello"));
            Assert.AreEqual("hello", ToggleCase.Toggle("HELLO"));
            Assert.AreEqual("Hello", ToggleCase.Toggle("hELLO"));
        }
    }
}
