using CS.Problems.DynamicProgramming.Minimizing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.Tests.DynamicProgramming.Minimizing
{
    /// <summary>
    /// Problem statement below
    /// https://www.geeksforgeeks.org/find-minimum-adjustment-cost-of-an-array/
    /// </summary>
    [TestClass]
    public class MinAdjustmentCost_Tests
    {
        [TestMethod]
        public void MinAdjustmentCost_Smoke_Test()
        {
            Assert.AreEqual(2, MinAdjustmentCost.Compute(new int[] { 1, 4, 2, 3 }, 1));
            Assert.AreEqual(3, MinAdjustmentCost.Compute(new int[] { 1, 3, 0, 3 }, 1));
            Assert.AreEqual(0, MinAdjustmentCost.Compute(new int[] { 2, 3, 2, 3 }, 1));

            Assert.AreEqual(75, MinAdjustmentCost.Compute(new int[] { 55, 77, 52, 61, 39, 6,
             25, 60, 49, 47 }, 10));
        }
    }
}
