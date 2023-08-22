using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class teenager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age = ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("He/She is teenager");
            }
            else
            {
                Console.WriteLine("He/She is Adult");
            }
        }
    }
}
