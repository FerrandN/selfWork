using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Teacher : Persons
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }
}
