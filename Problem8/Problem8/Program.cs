using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            long Result, Sum;
            Result = 0;

            string Num = "";
            string line;
            StreamReader file = new StreamReader("Number.txt");
            while((line = file.ReadLine()) != null)
            {
                Num += line;
            }
            
            for(int i = 0;i < 1000 - 13;i++)
            {
                Sum = 1;
                for(int j = 0;j < 13;j++)
                {
                    Sum = Sum * (Convert.ToInt64(Num[i + j]) - 48);
                }

                if(Sum > Result)
                {
                    Result = Sum;
                }
            }

            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
