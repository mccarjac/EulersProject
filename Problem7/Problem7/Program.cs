using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 6;
            int p = 13;
            while (count < 10001)
            {
                p += 1;
                if (isprime(p))
                {
                    count += 1;
                }
            }

            Console.WriteLine(p);
            Console.ReadKey();
        }

        public static bool isprime(int p)
        {
            for (int i = 2; i <= p / 2; i++)
            {
                if (p % i == 0)
                    return false;
            }
            return true;
        }
    }
}
