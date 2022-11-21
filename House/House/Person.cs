using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class Person
    {
        string nom;
        House house;
        public Person(string _nom)
        {
            this.nom = _nom;
            this.house = new Apartement();
        }
        public Person(string _nom, House _house)
        {
            this.nom = _nom;
            this.house = _house;
        }
        public void Display()
        {
            Console.WriteLine("Je m'appel " + this.nom + " et ma maison fait " + this.house.getSurface() + " m²" + " et elle a une porte de couleur " + this.house.getDoor());
        }

        public void getHouse()
        {
            this.house.Display();
        }
    }
}
