using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 2520;
            while (isdivisible(val))
            {
                val += 1;
            }

            Console.WriteLine(val);
            Console.ReadKey();
        }

        public static bool isdivisible(int val)
        {
            for (int i = 2; i < 20; i++)
            {
                if (val % i != 0)
                    return true;
            }
            return false;
        }
    }
}
