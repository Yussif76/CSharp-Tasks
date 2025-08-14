namespace day3
{
    static class Program
    {
        static void Main(string[] args)
        {

            SavingAccount save1 = new SavingAccount()
            {
                Fullname = "Ahmed Ali",
                AccountNumber = 101,
                NationalID = "12345678901234",
                PhoneNumber = "01012345678",
                Adress = "Cairo",
                Balance = 10000,
                InterestRate = 5
            };

            CurrentAccount current1 = new CurrentAccount()
            {
                Fullname = "Sara Mohamed",
                AccountNumber = 102,
                NationalID = "98765432109876",
                PhoneNumber = "01122334455",
                Adress = "Alexandria",
                Balance = 5000,
                OverdraftLimit = 2000
            };
            List<BankAccount> bankAccounts = new List<BankAccount>() { save1,current1 };
            foreach (var acc in bankAccounts) 
            {
                Console.WriteLine(acc.ShowAccountDetails());
            }

        }
    }
}
