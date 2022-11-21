using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class House
    {
        int surface;
        Doors door;
        public House()
        {
            door = new Doors();
            surface = 50;
        }
        public House(int _value)
        {
            door = new Doors();
            surface = _value;
        }

        public int getSurface()
        {
            return surface;
        }

        public void setSurface(int _value)
        {
            surface = _value;
        }
        public string getDoor()
        {
            return this.door.getColor();
        }
        public void Display()
        {
            Console.WriteLine("Je suis une maison, ma surface est de " + this.surface + " m²" + " avec une porte de couleur " + this.getDoor());
        }

    }
}
