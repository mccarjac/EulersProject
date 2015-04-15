using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 2;
            int sum = 0;
            int temp;

            while (second < 4000000)
            {
                temp = second;
                second = first + second;
                first = temp;
                if (first % 2 == 0)
                {
                    sum += first;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
