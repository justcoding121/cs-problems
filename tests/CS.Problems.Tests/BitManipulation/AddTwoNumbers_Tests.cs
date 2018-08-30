using CS.Problems.BitManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.Tests.BitManipulation
{
    /// <summary>
    /// Add two numbers using bitwise operators
    /// </summary>
    [TestClass]
    public class AddTwoNumbers_Tests
    {
        [TestMethod]
        public void AddTwoNumbers_Smoke_Test()
        {
            Assert.AreEqual(5, AddTwoNumbers.Add(3, 2));
            Assert.AreEqual(10, AddTwoNumbers.Add(5, 5));
        }
    }
}
