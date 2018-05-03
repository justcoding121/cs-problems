using CS.Problems.BitManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Problems.Tests.BitManipulation
{
    /// <summary>
    /// Problem details below
    /// http://www.geeksforgeeks.org/a-boolean-array-puzzle/
    /// </summary>
    [TestClass]
    public class BoolArrayPuzzle_Tests
    {
        [TestMethod]
        public void BoolArrayPuzzle_Smoke_Test()
        {
            CollectionAssert.AreEqual(new int[] { 0, 0 },
                BoolArrayPuzzle.ChangeToZero(new int[] { 0, 1 }));
        }
    }
}
