using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class WL1_10oddsum
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while(i <= 10)
            {
                if (i % 2 != 0)
                {
                    sum = sum+i;
                }
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
