using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    public class Collatz
    {
        long MaxChain;
        public long MaxNum;

        public Collatz()
        {
            MaxChain = 0;
            MaxNum = 0;
            Calculate();
        }

        public void Calculate()
        {
            long val;
            long tempchain;
            for(long i = 1;i < 1000000;i++)
            {
                val = i;
                tempchain = 1;
                while(val != 1)
                {
                    if (val % 2 == 0)
                        val = val / 2;
                    else
                        val = (3 * val) + 1;
                    tempchain += 1;
                }

                if(tempchain > MaxChain)
                {
                    MaxChain = tempchain;
                    MaxNum = i;
                }
            }
        }

    }
}
