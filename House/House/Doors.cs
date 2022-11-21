using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    public class Doors
    {
        string color;

        public Doors()
        {
            this.color = "rouge";
        }
        public Doors(string _color)
        {
            this.color = _color;
        }

        public void Display()
        {
            Console.WriteLine("Je suis une porte ma couleur est: " + color);
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string _color)
        {
            this.color = _color;
        }
    }
}
