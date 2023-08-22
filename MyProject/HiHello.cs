using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class HiHello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age");
            int Chidanand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Friend age");
            int Shubham = Convert.ToInt32(Console.ReadLine());

            if (Chidanand > Shubham)
            {
                Console.WriteLine("Hiiii");
            }
            else if (Chidanand < Shubham)
            {
                Console.WriteLine("Hellooo");
            }
            else
            {
                Console.WriteLine("HI-HELLO");
            }

        }
    }
}
