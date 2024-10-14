using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumberOOP
{
    internal class RationalNumber
    {
        private double numerator;
        private double denumerator;

        public double Numerator
        {  get { return numerator; }
           set { numerator = value; }
        }

        public double Denumerator
        {
            get { return denumerator; }
            set { denumerator = value; }
        }

        public RationalNumber() 
        { 
        }

        public RationalNumber(double n, double d)
        {
            var gcd = GCD((ulong)n, (ulong)d);
            numerator = n / gcd;
            denumerator = d / gcd;
        }

        public void Example()
        {
            //This is just an example method
        }

        public ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}
