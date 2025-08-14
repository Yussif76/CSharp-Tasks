using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class CurrentAccount : BankAccount
    {
        // additional field
        private decimal _overdraftLimit;

        public decimal OverdraftLimit {  get { return _overdraftLimit; } set { _overdraftLimit = value; }}

        public override decimal CalculateInterest()
        {
            return 0;
        }

        public override string ShowAccountDetails()
        {
            return base.ShowAccountDetails() +
                   $"\nOverdraft Limit: {OverdraftLimit}\n" + "-----------------";
        }

    }
}
