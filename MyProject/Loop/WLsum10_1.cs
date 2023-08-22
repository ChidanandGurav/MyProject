using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class WLsum10_1
    {
        static void Main(string[] args)
        {
            int i = 10;
            int sum = 0;
            while(i >= 1)
            {
                sum += i;
                i--;
            }
            Console.WriteLine(sum);
        }
    }
}
