using day2;
using System;
using System.Numerics;
class Program
    {
    static void Main(string[] args)
        {

        BankAccount b1 = new BankAccount();
        b1.Fullname = "Yussif Ahmed";
        b1.AccountNumber = 001;
        b1.NationalID = "12345678912345";
        b1.PhoneNumber = "01102265401";
        b1.Adress = "Benha";
        b1.Balance = 1000;
        


        BankAccount b2 = new BankAccount();
        b2.Fullname = "Ahmed Elsaree3";
        b2.AccountNumber = 002;
        b2.NationalID = "12345678912345";
        b2.PhoneNumber = "01044319020";
        b2.Adress = "Toukh";
        b2.Balance = 3000;


        Console.WriteLine(b1.ShowAccountDetails());
        Console.WriteLine(b2.ShowAccountDetails());



    }





}
    

