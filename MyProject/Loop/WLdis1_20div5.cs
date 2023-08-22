using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class WLdis1_20div5
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<=20)
            {
                if(i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
