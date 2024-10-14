using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumberOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<RationalNumber> list = new List<RationalNumber>();

            //input
            for (int i = 0; i < 3; i++)
            {
                var n = double.Parse(Console.ReadLine());
                var d = double.Parse(Console.ReadLine());
                RationalNumber rn = new RationalNumber(n,d);
                list.Add(rn);
                
            }

            //output
            foreach (var item in list) 
            {
                Console.WriteLine(item.Numerator + "/" + item.Denumerator);
            }

            Console.ReadKey();
        }
    }
}
