using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Banque
    {
        string brand;
        string town;
        string name;
        internal List<Account> BanqueAccount { get; set; }
        public Banque(string brand, string town, string name)
        {
            this.brand = brand;
            this.town = town;
            this.name = name;
            BanqueAccount = new List<Account>();
        }

        

        public void AddNewAccount()
        {
            BanqueAccount.Add(new Account(BanqueAccount.Count,"",0,100));
        }

        public void AddSetAccount(Account account)
        {
            BanqueAccount.Add(account);
        }

        public override string ToString()
        {
            String str = "Compte bancaire: {";
            foreach (Account c in BanqueAccount)
            {
                str += c;
            }
            return str;
        }
    }
}
