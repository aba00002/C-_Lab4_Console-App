using System;

namespace Lab4
{
    class Account
    {
        //instance attrributes
        private string accountNumber;
        private string ownerName;
        private double balance;
        private double monthlyDepositAmount;
        private int numberOfMonths;
        private double monthlyFee = 4.0;
        private double monthlyInterestRate = 0.0025;
        private int minimumInitialBalance = 1000;
        private int minimumMonthDeposit = 50;
        //properties
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }//end of property
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }//end of property
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }//end of property
        public double MonthlyDepositAmount
        {
            get { return monthlyDepositAmount; }
            set { monthlyDepositAmount = value; }
        }//end of property
        public double MonthlyFee
        {
            get { return monthlyFee; }
        }//end of property
        public double MonthlyInterestRate
        {
            get { return monthlyInterestRate; }
        }//end of property
        public int MinimumInitialBalance
        {
            get { return minimumInitialBalance; }
        }//end of property
        public int MinimumMonthDeposit
        {
            get { return minimumMonthDeposit; }
        }//end of property
        public int NumberOfMonths
        {
            get { return numberOfMonths; }
            set { numberOfMonths = value; }
        }
        //CONSTRUCTOR 1
        public Account(string ownerName, double initialDepositAmount)
        {
            OwnerName = ownerName;
            Balance = initialDepositAmount;
            Random generateAccNumber = new Random();
            accountNumber = "#"+ generateAccNumber.Next(90000, 99999).ToString();
        }//end of constructor

        //CONSTRUCTOR 2
        public Account(double monthlyDepositAmount, int numberOfMonths, double initialDepositAmount)
        {
            MonthlyDepositAmount = monthlyDepositAmount;
            NumberOfMonths = numberOfMonths;
            Balance = initialDepositAmount;
        }

        //MethodS
        public void Deposit()
        {
                Balance = Balance + MonthlyDepositAmount;     
        }
        public void Interest()
        {
           Balance = Balance + (Balance * MonthlyInterestRate);
        }
        public void Withdraw()
        {
            if (Balance >= MonthlyFee)
            {
                Balance = Balance - MonthlyFee;
            }
            else { Console.WriteLine("You have insufficient funds"); }
        }
    }
}