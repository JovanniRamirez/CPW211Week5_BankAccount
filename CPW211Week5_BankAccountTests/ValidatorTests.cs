using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211Week5_BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211Week5_BankAccount.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        [TestMethod()]
        [DataRow(0, 100, 0)]
        [DataRow(0, 100, 100)]
        [DataRow(0, 100, 49.99)]
        public void IsWithinRange_InclusiveRange_ReturnsTrue
                        (double min, double max, double test)
        {
            bool result = Validator.IsWithinRange(min, max, test);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow(0, 100, -.01)]
        [DataRow(0, 100, 100.1)]
        public void IsWithInRange_OutOfRangeValue_ReturnFalse(double min, double max, double test)
        {
            bool result = Validator.IsWithinRange(min, max, test);
            Assert.IsFalse(result);
        }
    }
}