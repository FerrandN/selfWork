using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Persons
    {
        protected int age;
        public void SetAge (int a)
        {
            age = a;
        }
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
