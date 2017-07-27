using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShortTermLoansModels;
using ShortTermLoansBusiness;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTotalRepay()
        {
            ShortTermLoanModel vm = new ShortTermLoanModel
            {
                MinCash = 50,
                MaxCash = 400,
                SelectedCash = 317,
                MinDays = 1,
                MaxDays = 35,
                Interest = Convert.ToDecimal(0.8),
                SelectedDays = 14
            };

            vm = ShortTermLoans.CalculateResult(vm);

            Assert.IsTrue(vm.ResultTotalRepay == Convert.ToDecimal(352.50));
        }
    }
}
