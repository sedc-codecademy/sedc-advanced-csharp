using System;
using System.Collections.Generic;

namespace G1_Interface
{
    internal class Mobster
    {
        public string Name { get; set; }
        public string Nickname { get; set; }

        public int Balance { get; private set; }

        public Mobster(string name, string nick)
        {
            Name = name;
            Nickname = nick;
            clients = new List<IPayable>();
        }

        private List<IPayable> clients;

        public void AddClient(IPayable client)
        {
            clients.Add(client);
        }

        internal void TakeCareOfBusiness()
        {
            foreach (var client in clients)
            {
                Balance += client.Withdraw(client.Balance / 2);
            }
        }
    }
}