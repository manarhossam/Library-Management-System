using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
     class PremiumMember : Member
    {
        public int MaxBorrowLimit { get; set; } = 10;
        public int LoanDays { get; set; } = 30;

        public PremiumMember(int id, string name, string email)
          : base(id, name, email)
        {
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   $"\nMax Borrow Limit: {MaxBorrowLimit}" +
                   $"\nLoan Days: {LoanDays}";
        }
    }
}
