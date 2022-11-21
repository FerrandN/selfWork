using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ImaginaryNumber
{
    public class Number
    {
        public double real;
        public double imaginary;
        string value;

        public Number(double a, double b)
        {
            real = a;
            imaginary = b;
        }
        public double GetReal()
        {
            return real;
        }
        public void SetReal(double real)
        {
            this.real = real;
        }

        public double GetImaginary()
        {
            return imaginary;
        }
        public void SetImaginary(double imaginary)
        {
            this.imaginary = imaginary;
        }

        public string ToString()
        {
            value = real + " " + imaginary;
            return value;
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(real * real + imaginary * imaginary);
        }

        public void Sum(Number c)
        {
            real += c.GetReal();
            imaginary += c.GetImaginary();
        }
    }
}
