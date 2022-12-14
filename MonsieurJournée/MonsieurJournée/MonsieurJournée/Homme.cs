using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsieurJournée
{
    internal class Homme
    {
        int age;
        string name = "";
        int argent = 0;
        string toDisplayIfUnderAge = "Le petit ";
        string toDisplayIfAdult = "Monsieur ";
        public Homme(int _age, string _name)
        {
            age = _age;
            name = _name;
        }

        public string Dormir()
        {
            return CheckAge() + name + " va se coucher";
        }
        public string Jouer()
        {
            return CheckAge() + name +" s'amuse bien";
        }
        public string Manger()
        {
            return CheckAge() + name + " est rassasié";
        }
        public string Travailler()
        {
            return CheckAge() + name + (age>= 18 ? " va travailler" : " va à l'école");
            argent += 100;
        }

        private string CheckAge()
        {
            if (age >= 18)
                return toDisplayIfAdult;
            else
                return toDisplayIfUnderAge;
        }
    }
}
