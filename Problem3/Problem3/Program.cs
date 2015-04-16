using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            long val = 600851475143;
            long i;
            for(i = Convert.ToInt64(Math.Ceiling(Math.Sqrt(val)));i > 1;i--)
            {
                if (val % i == 0 && isprime(i))
                    break;
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }

        static bool isprime(long val)
        {
            for(long i = 2;i < Math.Ceiling(Math.Sqrt(val));i++)
            {
                if (val % i == 0)
                    return false;
            }
            return true;
        }
    }
}
