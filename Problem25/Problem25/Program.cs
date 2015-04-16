using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem25
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BigInteger first = new BigInteger();
            BigInteger second = new BigInteger();
            BigInteger temp = new BigInteger();
            first = 1;
            second = 1;
            long count = 2;
            while(second.ToString().Length < 1000)
            {
                temp = second;
                second = BigInteger.Add(first, second);
                first = temp;
                count += 1;
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
