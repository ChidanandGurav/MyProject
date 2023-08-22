using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Compair
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No = ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Number is Similer");
            }
            else
            {
                Console.WriteLine("No Similer");
            }
        }
    }
}
