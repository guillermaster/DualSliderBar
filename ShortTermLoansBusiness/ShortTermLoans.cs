using ShortTermLoansModels;
using System;

namespace ShortTermLoansBusiness
{
    public class ShortTermLoans
    {
        public static ShortTermLoanModel CalculateResult(ShortTermLoanModel model)
        {
            model.ResultBorrowing = model.SelectedCash;
            model.ResultInterest = Math.Truncate(model.Interest * model.SelectedDays * model.SelectedCash) / 100;
            model.ResultTotalRepay = model.ResultBorrowing + model.ResultInterest;
            model.EndDate = CalculateEndDate(model);
            model.DueDate = model.EndDate.ToString("D");

            return model;
        }

        public static DateTime CalculateEndDate(ShortTermLoanModel model)
        {
            return model.StartDate.AddDays(model.SelectedDays);
        }
    }
}
