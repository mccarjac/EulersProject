using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            for(int i = 999;i > 0;i--)
            {
                for(int j = i;j > 0;j--)
                {
                    if(IsPalindrome(i * j))
                    {
                        if(i * j > Result)
                        {
                            Result = i * j;
                        }
                    }
                }
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }

        public static bool IsPalindrome(int Value)
        {
            string Num = Convert.ToString(Value);
            for(int i = 0;i < Num.Length / 2;i++)
            {
                if(Num[i] != Num[Num.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
