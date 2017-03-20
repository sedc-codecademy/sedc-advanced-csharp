using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Interface
{
    class Mobster
    {
        public string Name { get; set; }
        public int Balance { get; private set; }
        List<IPayable> clients;

        public Mobster(string name)
        {
            clients = new List<IPayable>();
            Name = name;
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
    }
}
