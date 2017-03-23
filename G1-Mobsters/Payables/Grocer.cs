using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Mobsters.Payables
{
    class Grocer : IPayable
    {
        public string Name { get; set; }

        public int Balance { get; private set; }

        public Grocer(string name)
        {
            Name = name;
        }

        public int Withdraw(int ammount)
        {
            #region Guard clauses
            if (ammount < 0)
            {
                throw new WithdrawalException();
            }
            if (ammount > Balance)
            {
                throw new WithdrawalException();
            }
            #endregion
            Balance -= ammount;
            return ammount;
        }

        public void Deposit(int ammount)
        {
            #region Guard clauses
            if (ammount < 0)
            {
                throw new WithdrawalException();
            }
            #endregion
            Balance += ammount;
        }

        public void SellVegetable(string type, int factor = 1)
        {
            Deposit(100 * factor);
        }
    }
}
