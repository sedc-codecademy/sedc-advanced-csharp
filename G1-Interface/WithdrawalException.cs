using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Interface
{
    class WithdrawalException : ApplicationException
    {
        public WithdrawalException(int ammount, int balance):
            base($"Insufficient funds. Requested {ammount}, available {balance}")
        {

        }
    }
}
