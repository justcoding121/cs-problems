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
    public class BalanceParentheses_Tests
    {
        [TestMethod]
        public void BalanceParentheses_Smoke_Test()
        {
            Assert.AreEqual("ab", BalanceParentheses.Balance("ab"));
            Assert.AreEqual("ab", BalanceParentheses.Balance("((ab"));
            Assert.AreEqual("ab", BalanceParentheses.Balance("(ab"));
            Assert.AreEqual("ab", BalanceParentheses.Balance("ab))"));

            Assert.AreEqual("((ab))", BalanceParentheses.Balance("((ab))"));
            Assert.AreEqual("(ab)", BalanceParentheses.Balance("(ab))"));
            Assert.AreEqual("(ab)", BalanceParentheses.Balance("((ab)"));

            Assert.AreEqual("a(b)", BalanceParentheses.Balance("a(b)"));
            Assert.AreEqual("", BalanceParentheses.Balance("(((("));
            Assert.AreEqual("(()())", BalanceParentheses.Balance("(()())"));

            Assert.AreEqual("ab()", BalanceParentheses.Balance(")ab(()"));
            Assert.AreEqual("ab()", BalanceParentheses.Balance(")))ab(()(("));
        }
    }
}
