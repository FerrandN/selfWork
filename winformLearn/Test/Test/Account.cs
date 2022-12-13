using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Account
    {
        int id;
        public string owner { get; private set; }
        double balance;
        double overdraft;
        public Account(int id, string owner, double balance, double overdraft)
        {
            this.id = id;
            this.owner = owner;
            this.balance = balance;
            this.overdraft = overdraft;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("{0}{1}{2}{3}","Numero d'identification du compte" + id + " ", "Nom du propriétaire" + owner + " ", "Solde" + balance + " ", "Découvert autorisé" + overdraft + " ");
        }

        public double AddMoney(double toAdd)
        {
            return balance += toAdd;
        }

        public bool TryWithdraw(double toWithdraw)
        {
            return (balance - Math.Abs(toWithdraw) ) < overdraft ? false : true;
        }

        public double Withdraw(double toWithdraw)
        {
            if(TryWithdraw(toWithdraw))
            {
                balance -= toWithdraw;
            }
            else
            {
                throw new Exception("Balance to low");
            }
            return balance;
        }

        public bool Transfert(Account toWithdrawFrom, Account toAddTo, double value)
        {
            if(TryWithdraw(toWithdrawFrom.balance))
            {
                return false;
            }
            else
            {
                toWithdrawFrom.balance = Withdraw(value);
                toAddTo.balance = AddMoney(value);
                return true;
            }
        }

        public bool CompareTwoAccount(Account toWithdrawFrom, Account toAddTo)
        {
            if(toWithdrawFrom.balance < toAddTo.balance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return String.Format("id: {0}, owner: {1}, balance : {2}, overdraft: {3}",
                id, owner, balance, overdraft);
        }
    }
}
