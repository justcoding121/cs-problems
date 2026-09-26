using CS.Problems.Miscellaneous;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Problems.Tests.Miscellaneous
{
    [TestClass]
    public class MatrixMultication_Tests
    {
        [TestMethod]
        public void MatrixMultication_Smoke_Test()
        {
            var N = 2;
            int[,] A = new int[N, N], B = new int[N, N];

            A[0, 0] = 1; A[0, 1] = 2;
            A[1, 0] = 1;A[1, 1] = 4;

            B[0, 0] = 2; B[0, 1] = 0;
            B[1, 0] = 1; B[1, 1] = 2;

            var result =  MatrixMultiplication.Multiply(A, B);

            Assert.AreEqual(4, result[0, 0]);
            Assert.AreEqual(4, result[0, 1]);
            Assert.AreEqual(6, result[1, 0]);
            Assert.AreEqual(8, result[1, 1]);

            var A2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            var B2 = new int[3, 4] {
                { 1, 0, 0, 0 },
                { 0, 1, 0, 0 },
                { 0, 0, 1, 0 }
            };
            var rectangular = MatrixMultiplication.Multiply(A2, B2);
            Assert.AreEqual(2, rectangular.GetLength(0));
            Assert.AreEqual(4, rectangular.GetLength(1));
            Assert.AreEqual(1, rectangular[0, 0]);
            Assert.AreEqual(2, rectangular[0, 1]);
            Assert.AreEqual(3, rectangular[0, 2]);
            Assert.AreEqual(0, rectangular[0, 3]);
        }
    }
}
