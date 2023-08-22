using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class _1_20divby5
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 20; i++)
                if(i % 5 ==0)
            {
                    Console.WriteLine(i);
            }
        }
    }
}
