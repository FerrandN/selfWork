using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cercle
{
    class CircleDatas
    {
        public double R;
        public CircleDatas(double Rayon)
        {
            R = Rayon;
        }
        public double GetArea()
        {
            return R * R * Math.PI;
        }
        public double GetPerimeter()
        {
            return 2 * R * Math.PI;
        }
    }
}
