using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    class Account : Object
    {
        public Account(string name)
        {
            AccountName = name;
        }

        public string AccountName { get; private set; }

        private int balance;

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value <0)
                {
                    throw new ArgumentException("Account balance cannot be negative");
                }
                balance = value;
            }
        }


        //public int GetBalance()
        //{
        //    return balance;
        //}

        //public void SetBalance(int value)
        //{
        //    if (value >=0)
        //    {
        //        balance = value;
        //    }
        //}

        public override string ToString()
        {
            return $"Account balance is {balance}";
        }

    }
}
