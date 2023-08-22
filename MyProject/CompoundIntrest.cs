using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class CompoundIntrest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principle Amount");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter time Period");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate");
            int r = Convert.ToInt32(Console.ReadLine());

            double ci = 0;

            ci = p * (1 + r / 100) ^ t;
            Console.WriteLine("Compount Intrest :" + ci);
        }
    }
}
