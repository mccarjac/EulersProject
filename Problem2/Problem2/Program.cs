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
            int First = 1;
            int Second = 2;
            int Sum = 0;
            int Temp;

            while (Second < 4000000)
            {
                Temp = Second;
                Second = First + Second;
                First = Temp;
                if (First % 2 == 0)
                {
                    Sum += First;
                }
            }
            Console.WriteLine(Sum);
            Console.ReadKey();
        }
    }
}
