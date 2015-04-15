using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            int SumSquare = 0;
            int SquareSum = 0;
            for(int i = 0;i <= 100;i++)
            {
                SumSquare += Convert.ToInt32(Math.Pow(i, 2));
                SquareSum += i;
            }
            SquareSum = Convert.ToInt32(Math.Pow(SquareSum, 2));
            int Result = SquareSum - SumSquare;
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
