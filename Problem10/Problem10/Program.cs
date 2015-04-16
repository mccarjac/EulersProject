using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 17;
            for(long i = 10;i < 2000000;i++)
            {
                if (isprime(i))
                    sum += i;
            }

            string result = Convert.ToString(sum);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static bool isprime(long val)
        {
            for(long i = 2;i <= Math.Ceiling(Math.Sqrt(val));i++)
            {
                if (val % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
