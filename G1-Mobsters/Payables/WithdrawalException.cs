using System;
using System.Runtime.Serialization;

namespace G1_Mobsters.Payables
{
    [Serializable]
    internal class WithdrawalException : ApplicationException
    {
        public WithdrawalException() : base("Withdrawal exception")
        {
        }
    }
}