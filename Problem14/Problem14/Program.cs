using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            Collatz sln = new Collatz();

            Console.WriteLine(sln.MaxNum);
            Console.ReadKey();
        }
    }
}
