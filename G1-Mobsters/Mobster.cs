using G1_Mobsters.Payables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_Mobsters
{
    public class Mobster : IPayable
    {
        public string Name { get; set; }
        public string Nickname { get; set; }

        public int Balance { get; private set; }

        List<IPayable> clients;

        public Mobster(string name, string nickname)
        {
            Name = name;
            Nickname = nickname;
            Balance = 0;
            clients = new List<IPayable>();
        }

        public override string ToString()
        {
            return $"I'm {Name} the {Nickname}, and my balance is {Balance}";
        }

        public void AddClient(IPayable client)
        {
            clients.Add(client);
        }

        public void TakeCareOfBusiness()
        {
            foreach (var client in clients)
            {
                this.Deposit(client.Withdraw(client.Balance / 2));
            }
        }

        public void GiveCharity()
        {
            foreach (var client in clients)
            {
                var charity = client.TakeCharity();
                this.Withdraw(charity);
            }
        }

        public List<string> ListClients()
        {
            var result = new List<string>();
            foreach (var client in clients)
            {
                result.Add(client.ToString());
            }
            return result;
        }

        public int Withdraw(int ammount)
        {
            Balance -= ammount;
            return ammount;
        }

        public void Deposit(int ammount)
        {
            Balance += ammount;
        }
    }
}
