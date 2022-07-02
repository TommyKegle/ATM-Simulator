using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Simulator
{
    class ATM
    {
        
        static public void MainMenu()
        {
            while(1 == 1)
            {

                int inputMain;

                Console.WriteLine("Main Menu\n\n1: Select Account\n2: Create Account\n3: Exit\n\nEnter a choice: ");
                inputMain = Convert.ToInt32(Console.ReadLine());

                if(inputMain == 1)
                {
                

                }
                else if(inputMain == 2)
                {
                    OnCreateAccount();

                }
                else if(inputMain == 3)
                {
                    return;

                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }

        }

        public static void OnCreateAccount()
        {
            string inputName;
            decimal inputBalance;
            int inputIntRate;
            string inputAcctType;
            int inputAccountNum = 0;
            string failSafe;


            Console.WriteLine("Please enter the client name or press [ENTER] to cancel: ");
            inputName = Convert.ToString(Console.ReadLine());
            if(inputName == "")
            {
                return;
            }

            Console.WriteLine("Please enter your initial balance: ");
            inputBalance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the interest rate for this account: ");
            inputIntRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the account type [c/s; chequing/savings]: ");
            inputAcctType = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter the account number [110 - 1000] or press [ENTER] to cancel: ");
            failSafe = Convert.ToString(Console.ReadLine());
            if(failSafe == "")
            {
                return;
            }
            else
            {
                inputAccountNum = Convert.ToInt32(failSafe);
            }

            if(inputAcctType == "c")
            {
                Account.Checking acct = new Account.Checking();
                acct.acctHolderName = inputName;
                acct.acctNo = inputAccountNum;
                acct.annualIntrRate = inputIntRate;
                acct.balance = inputBalance;

            }
            else if(inputAcctType == "s")
            {

            }

            

        }

 

    }
}
