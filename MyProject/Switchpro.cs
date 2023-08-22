using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Switchpro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any two Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add");
            Console.WriteLine("Sub");
            Console.WriteLine("Mul");
            Console.WriteLine("Div");
            Console.WriteLine("Mod");

            Console.WriteLine("Enter Choice");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Addition of Two No." + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Subtraction of Two No." + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication of Two No." + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division of Two No." + (a / b));
                    break;
                case 5:
                    Console.WriteLine("Mod of Two No." + (a % b));
                    break;


            }
        }
    }
}
