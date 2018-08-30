
using CS.Problems.Miscellaneous;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.Tests.Miscellaneous
{

    [TestClass]
    public class LongestOnesWithKFlips_Tests
    {
        [TestMethod]
        public void LongestOnesWithKFlips_Smoke_Test()
        {

            //recursive solution tests
            Assert.AreEqual(7, LongestOnesWithKFlips.ComputeRecursive("11001100111", 2));
            Assert.AreEqual(8, LongestOnesWithKFlips.ComputeRecursive("10011010111", 2));
            Assert.AreEqual(5, LongestOnesWithKFlips.ComputeRecursive("10011010111", 1));
            Assert.AreEqual(4, LongestOnesWithKFlips.ComputeRecursive("0001", 4));

            //Iterative solution tests
            Assert.AreEqual(7, LongestOnesWithKFlips.ComputeIterative("11001100111", 2));
            Assert.AreEqual(8, LongestOnesWithKFlips.ComputeIterative("10011010111", 2));
            Assert.AreEqual(5, LongestOnesWithKFlips.ComputeIterative("10011010111", 1));
            Assert.AreEqual(4, LongestOnesWithKFlips.ComputeIterative("0001", 4));

        }
    }
}
