using System;
using System.Collections;

namespace Lab4
{
    public class Bank
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of months to deposit: "); //ENTER NUMBER OF MONTHS TO DEPOSIT
            int numberOfMonths = Convert.ToInt32(Console.ReadLine());
            string ownerName;
            double monthlyDepositAmount = 0.0;
            double initialDepositAmount = 0.0;
            bool loop1 = true;
            ArrayList diplayOwnerName = new ArrayList(); //ARRAY FOR ACCOUNT HOLDER'S NAME
            ArrayList displayAccountNumber = new ArrayList(); // ARRAY FOR ACCOUNT NUMBERS
            ArrayList displayBalance = new ArrayList(); // ARRAY FOR CURRENT BALANCE
            while (loop1 == true)
            {
                Console.WriteLine("");
                Console.Write("Enter customer name: "); //ENTER ACCOUNT OWNER NAME
                ownerName = Console.ReadLine();
                if (ownerName != "")
                {
                    Console.Write("Enter {0}'s Initial Deposit Amount(minimum $1,000.00): ", ownerName); //ENTER AN INITIAL DEPOSIT ABOVER $1000
                    double y = Convert.ToDouble(Console.ReadLine());
                    if (y >= 1000)
                    {
                        initialDepositAmount = y;
                    }
                    else
                    {
                        Console.WriteLine("The system requires a minimum initial deposit of $1,000.00 to proceed.Goodbye");
                        break;
                    }
                    Console.Write("Enter {0}'s Monthly Deposit Amount(minimum $50.00): ", ownerName); //ENTER MONTHLY DEPOSIT ABOVE $50
                    double z = Convert.ToDouble(Console.ReadLine());
                    if (z >= 50)
                    {
                        monthlyDepositAmount = z;
                    }
                    else
                    {
                        Console.WriteLine("The system requires a minimum monthly deposit of $50.00 to proceed. Goodbye");
                        break;
                    }
                    Account obj = new Account(ownerName, initialDepositAmount); //USING CONSTRUCTOR
                    Account con = new Account(monthlyDepositAmount, numberOfMonths, initialDepositAmount); //USING CONSTRUCTOR

                    for (int i = 0; i < numberOfMonths; i++) //FOR EACH MONTH, CALCULATE CURRENT BALANCE
                    {
                        con.Withdraw();
                        con.Interest();
                        con.Deposit();
                        }
                    con.Balance = Math.Round((Double)con.Balance, 2); //ROUNDING TO 2 DECIMAL PLACES
                    diplayOwnerName.Add(obj.OwnerName); //ADDING NEW VALUE TO ARRAY
                    displayAccountNumber.Add(obj.AccountNumber); //ADDING NEW VALUE TO ARRAY
                    displayBalance.Add(con.Balance); //ADDING NEW VALUE TO ARRAY
                }
                if (ownerName == "") //EXIT LOOP IF NO NAME IS ENTERED
                { loop1 = false;}
            }
            Console.WriteLine("");
            for (int i = 0; i < displayAccountNumber.Count; i++)
            {
                //PRINT TO CONSOLE ACCOUNT DETAILS
                Console.WriteLine("After {0} months, {1}'s account ({2}), has a balance of: {3}", numberOfMonths, diplayOwnerName[i], displayAccountNumber[i], "$" + displayBalance[i]);
            }   
            Console.WriteLine("");
            Console.WriteLine("Press Enter to complete");
            Console.Read();
        }
        }
    }

