using CS.Problems.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Problems.Tests.DynamicProgramming
{
    /// <summary>
    /// Problem statement in detail below
    /// http://www.geeksforgeeks.org/program-for-nth-fibonacci-number/
    /// </summary>
    [TestClass]
    public class Fibonacci_Tests
    {
        [TestMethod]
        public void Fibonacci_Smoke_Test()
        {
            var numbers = FibonacciGenerator.GetFibonacciNumbers(10);

            Assert.AreEqual(55, numbers[9]);
        }
    }
}
