using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class greaterthan5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number = ");
            int num = Convert.ToInt32(Console.ReadLine());  

            if (num >= 5)
            {
                Console.WriteLine(" Yes, It is Greater than 5 ");
            }
            else
            {
                Console.WriteLine("Flase");
            }

        }
    }
}
