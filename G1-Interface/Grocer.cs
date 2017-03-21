using System;

namespace G1_Interface
{
    class Grocer : IPayable
    {
        public Grocer(string name)
        {
            Name = name;
            Balance = 0;
            Price = 100;
        }

        public string Name { get; set; }
        public int Balance { get; private set; }
        public int Price { get; set; }

        public int Withdraw(int ammount)
        {
            if (Balance < ammount)
            {
                throw new WithdrawalException(ammount, Balance);
            }
            Balance -= ammount;
            return ammount;
        }

        public void Sell(string produce, int factor = 1)
        {
            Console.WriteLine($"Selling nice fresh {produce}");
            Balance += factor * Price;
        }
    }
}