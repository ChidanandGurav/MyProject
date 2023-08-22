using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class MaxNoOf3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int num3 = Convert.ToInt32(Console.ReadLine()); 

            if(num1>num3)
            {
                if (num1>num2)
                {
                    Console.WriteLine("Number one is Greater");
                }
                else
                {
                    Console.WriteLine("Number Third is Greater");
                }
            }
            else if (num2>num3)
            {
                Console.WriteLine("Number Two is Greater");
            }
            else
            {
                Console.WriteLine("Number Third is Greater");
            }
        }
    }
}
