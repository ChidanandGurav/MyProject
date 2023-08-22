using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Exam
{
    internal class _4_1to50ESqureandONagative
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
    
                if (i % 2 == 0)
                {
                  int sq = i * i;
                    Console.WriteLine("Even No = " +sq);
                }
            else
                {
                    Console.WriteLine("Odd No = "  + (-i));
                }
           
        }
    }
}
