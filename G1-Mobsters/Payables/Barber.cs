using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Mobsters.Payables
{
    class Barber : IPayable
    {
        public string Name { get; set; }

        public int Balance { get; private set; }

        public Barber(string name)
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

        public void Shave()
        {
            Deposit(150);
        }

        public void Makeover()
        {
            Deposit(1000);
        }

        public override string ToString()
        {
            return $"I'm {Name} the barber and my balance is {Balance}";
        }

    }
}
