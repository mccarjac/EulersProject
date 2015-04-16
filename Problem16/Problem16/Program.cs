using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = new BigInteger();
            num = BigInteger.Pow(2, 1000);
            string str = num.ToString();

            BigInteger val = new BigInteger();
            val = 0;
            foreach(char a in str)
            {
                val = BigInteger.Add(val, (int)a - 48);
            }

            Console.WriteLine(val);
            Console.ReadKey();
        }
    }
}
