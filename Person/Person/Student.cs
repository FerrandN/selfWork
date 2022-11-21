using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Student : Persons
    {
        public void GoToClass()
        {
            Console.WriteLine("I am going to class.");
        }
        public void DisplayAge()
        {
            Console.WriteLine(age);
        }
    }
}
