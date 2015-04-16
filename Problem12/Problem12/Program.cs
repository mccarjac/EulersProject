using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            long count = 1;
            long num = 1;
            while (!fivehundivisors(num))
            {
                count += 1;
                num += count;
            }

            Console.WriteLine(num);
            Console.ReadKey();
        }

        static bool fivehundivisors(long val)
        {
            int count = 0;
            for(int i = 1;i <= Math.Ceiling(Math.Sqrt(val));i++)
            {
                if (val % i == 0)
                {
                        count += 1;
                }
            }

            count = count * 2;

            if (count > 500)
                return true;
            else
                return false;
        }
    }
}
