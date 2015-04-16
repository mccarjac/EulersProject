using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger val = new BigInteger();
            val = 1;
            for(int i = 2;i <= 100;i++)
            {
                val = BigInteger.Multiply(val, i);
            }

            string str = val.ToString();

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
