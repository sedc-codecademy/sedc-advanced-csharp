using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Interface
{
    class Mobster : IPayable
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Balance { get; private set; }

        public int Price { get; set; }

        List<IPayable> clients;

        public Mobster(string name, string nick)
        {
            clients = new List<IPayable>();
            Name = name;
            Nickname = nick;
            Balance = 0;
        }

        public void AddClient(IPayable client)
        {
            clients.Add(client);
        }

        public void TakeCareOfBusiness()
        {
            foreach (var client in clients)
            {
                var balance = client.Balance;
                client.Withdraw(balance / 2);
                Balance += balance / 2;
            }
        }

        public void Withdraw(int ammount)
        {
            if (Balance < ammount)
                Balance = 0;

            Balance -= ammount;
        }

        public override string ToString()
        {
            return $"I'm {Name} the {Nickname}, and I have {clients.Count} clients. My balance is {Balance}";
        }
    }
}
