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
    /// Problem details below
    /// </summary>
    [TestClass]
    public class ParityBit_Tests
    {
        [TestMethod]
        public void ParityBit_Smoke_Test()
        {
            //13=> 1101 so should be odd parity
            Assert.AreEqual(true, ParityFinder.Find(13));
        }
    }
}
