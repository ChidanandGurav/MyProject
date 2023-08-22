using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class PositiveNagativeZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

           if (num == 0) 
            {
                Console.WriteLine("Number is Zero");
            }
           else if (num > 0)
            {
                Console.WriteLine("Number is Positive");
            }
           else
            {
                Console.WriteLine("Number is Negative");
            }
        }
    }
}
