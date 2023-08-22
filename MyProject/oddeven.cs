using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No ");
            int n = int.Parse(Console.ReadLine());


            if (n % 2 == 0)
            {
                Console.WriteLine("Even " + n);
            }
            else
            {
                Console.WriteLine("ODD  " + n);
            }
        }
    }
}
