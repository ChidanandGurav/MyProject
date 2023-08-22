using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyProject
{
    internal class SingleDoubleDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number = ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 10)
            {
                Console.WriteLine("It is single Digit");
            }
            else
            {
                Console.WriteLine("It is Double Digit");
            }
        }
    }
}
