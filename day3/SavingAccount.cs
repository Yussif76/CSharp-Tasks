using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class SavingAccount : BankAccount
    {
        // additional field
        private decimal _interestRate;

        public decimal InterestRate { get; set; }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate /100;
        }
        public override string ShowAccountDetails()
        {
            return base.ShowAccountDetails()+ $"\nInterest Rate: {InterestRate}\n" + "-----------------";

        }





    }


}
