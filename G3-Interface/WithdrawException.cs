using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Interface
{
    class WithdrawException : ApplicationException
    {
        public int AmmountRequested { get; private set; }
        public int CurrentBalance { get; private set; }
        public int Overdraw { get; private set; }

        public WithdrawException(string message) : base(message)
        {
        }

        public WithdrawException(int ammount, int balance)
            : base($"Insufficient balance, requested {ammount}, available {balance}")
        {
            AmmountRequested = ammount;
            CurrentBalance = balance;
            Overdraw = ammount - balance;
        }
    }
}
