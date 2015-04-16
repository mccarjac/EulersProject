using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            for (a = 1; 1000 - 2 * a > a; a++)
            {
                for (b = a; 1000 - a - b > b; b++)
                {
                    c = 1000 - a - b;
                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        Console.WriteLine(a + " " + b + " " + c);
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                }
            }
        }
    }
}
