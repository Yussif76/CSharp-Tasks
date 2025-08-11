using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day2
{
    class BankAccount
    {
        private const string BankCode = "BNK001";
        private readonly DateTime CreatedDate;
        private int _accountNumber;
        private string _fullName; //Field
        private string _nationalID;
        private string _phoneNumber;
        private string _adress;
        private decimal _balance;

        public string Fullname
        {
            get { return _fullName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Full name cannot be empty.");
                    return;
                }
                _fullName = value;
            }
        } //Property 
        public string NationalID
        {
            get { return _nationalID; }
            set
            {
                if (value.Length != 14)
                {
                    Console.WriteLine("National ID must be 14 digits.");
                    return;
                }
                else
                {
                    _nationalID = value;

                }
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }

            set
            {
                if (value.Length != 11 || !value.StartsWith("01"))
                {
                    Console.WriteLine("Invalid Number");
                    return;
                }
                else
                {
                    _phoneNumber = value;
                }
            }

        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public decimal Balance
        {
            get { return _balance; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative.");
                    return;
                }
                _balance = value;
            }
        }
        public int AccountNumber { get { return _accountNumber; }
            set
            {
                _accountNumber = value;
            }

        }


        // Default constructor
        public BankAccount()
        {
            _fullName = "Unknown";
            _nationalID = "00000000000000";
            //Console.WriteLine("Default constructor");
        }
  

        // Parameterized constructor
        public BankAccount(string FullName, string NationalID, string PhoneNumber,string Address, decimal Balance) { 
            _fullName = FullName;
            _nationalID = NationalID;
            _phoneNumber = PhoneNumber;
            _adress = Address;
            _balance = Balance;
        }

        
        // Overloaded constructor






        // Methods
        public string ShowAccountDetails()
        {
            return
                   $"Object data : \n" +
                   $"Full Name: {_fullName}\n" +
                   $"Account Number: {_accountNumber:d3}\n" +
                   $"National ID: {_nationalID}\n" +
                   $"Phone Number: {_phoneNumber}\n" +
                   $"Address: {_adress}\n" +
                   $"Balance: {_balance}\n" +
                   "---------------";
        }

        public bool IsValidNationalID() {
            if (NationalID.Length != 14)
            {
                return false;
            }
            else
            {
                return true;

            }

        }


        




    }



}

