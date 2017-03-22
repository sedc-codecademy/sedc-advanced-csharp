using System;

namespace G3_Mobsters.Payables
{
    internal class WithdrawException : ApplicationException
    {
        private int Ammount { get; set; }
        private int Balance { get; set; }

        public WithdrawException(int ammount, int balance) 
            : base ($"Insuficient funds, requested {ammount}, available {balance}")
        {
            Ammount = ammount;
            Balance = balance;
        }
    }
}