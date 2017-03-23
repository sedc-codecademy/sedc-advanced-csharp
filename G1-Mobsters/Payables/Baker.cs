using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Mobsters.Payables
{
    class Baker : IPayable
    {
        public string Name { get; set; }

        public int Balance { get; private set; }

        public Baker(string name)
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

        public void SellPie(PieType pieType, PieSize pieSize)
        {
            int basePrice;
            int factor;

            switch (pieType)
            {
                case PieType.Apple:
                    basePrice = 100;
                    break;
                case PieType.Pumpkin:
                    basePrice = 120;
                    break;
                case PieType.Meat:
                    basePrice = 250;
                    break;
                case PieType.Blueberry:
                    basePrice = 180;
                    break;
                default:
                    throw new ArgumentException("pieType");
            }


            switch (pieSize)
            {
                case PieSize.Small:
                    factor = 1;
                    break;
                case PieSize.Medium:
                    factor = 2;
                    break;
                case PieSize.Large:
                    factor = 3;
                    break;
                case PieSize.ExtraLarge:
                    factor = 5;
                    break;
                default:
                    throw new ArgumentException("pieSize");
            }

            Deposit(basePrice * factor);
        }

        public void SellBoureque()
        {

        }
    }
}
