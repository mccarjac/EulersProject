using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = File.ReadAllLines("nums.txt");
            BigInteger[] bignums = new BigInteger[100];
            int i, j;
            i = 0;
            foreach(string num in nums)
            {
                bignums[i] = 0;
                j = 50;
                foreach(char a in num)
                {
                    bignums[i] = BigInteger.Add(bignums[i], BigInteger.Multiply((int)a - 48, BigInteger.Pow(10, j)));
                }
                i++;
            }

            BigInteger total = new BigInteger();
            total = 0;
            foreach(BigInteger big in bignums)
            {
                total = BigInteger.Add(total, big);
            }
            string str = total.ToString();
            str = str.Substring(0, 10);

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
