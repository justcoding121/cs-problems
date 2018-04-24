
using CS.Problems.Miscellaneous;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.Tests.Miscellaneous
{
    /// <summary>
    /// Problem details below
    /// http://www.geeksforgeeks.org/counting-inversions/
    /// </summary>
    [TestClass]
    public class LongestOnesWithKFlips_Tests
    {
        [TestMethod]
        public void LongestOnesWithKFlips_Smoke_Test()
        {
           Assert.AreEqual(7, LongestOnesWithKFlips.ComputeR("11001100111", 2));
           Assert.AreEqual(8, LongestOnesWithKFlips.ComputeR("10011010111", 2));
           Assert.AreEqual(5, LongestOnesWithKFlips.ComputeR("10011010111", 1));
           Assert.AreEqual(4, LongestOnesWithKFlips.ComputeR("0001", 4));

        }
    }
}
