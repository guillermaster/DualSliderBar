using System;

namespace ShortTermLoansModels
{
    public class ShortTermLoanModel
    {
        public ShortTermLoanModel()
        {
            StartDate = DateTime.Now;
        }

        public int MinCash { get; set; }

        public int MaxCash { get; set; }
        
        public int SelectedCash { get; set; }

        public int MinDays { get; set; }

        public int MaxDays { get; set; }
        
        public int SelectedDays { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string DueDate { get; set; }

        public decimal Interest { get; set; }

        public int ResultBorrowing { get; set; }

        public decimal ResultInterest { get; set; }

        public decimal ResultTotalRepay { get; set; }
    }
}
