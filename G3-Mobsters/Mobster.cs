using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Mobsters
{
    public class Mobster
    {
        List<IPayable> clients;
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Balance { get; private set; }


        public Mobster(string name, string nickname)
        {
            Name = name;
            Nickname = nickname;
            Balance = 0;
            clients = new List<IPayable>();
        }

        public void AddClient(IPayable client)
        {
            clients.Add(client);
        }

        public void TakeCareOfBusiness()
        {
        }

        public override string ToString()
        {
            return $"I'm {Name} the {Nickname}, and I have ${Balance}";
        }
    }
}
