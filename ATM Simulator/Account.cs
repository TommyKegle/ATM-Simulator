using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Simulator
{
    public class Account
    {
        public string acctHolderName;
        public int acctNo;
        public float annualIntrRate;
        public decimal balance;


        public class Checking : Account
        {




        }

        public class Saving : Account
        {




        }

       

    }
}
