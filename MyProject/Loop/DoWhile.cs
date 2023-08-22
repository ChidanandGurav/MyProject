using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    public class DoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            char ch;

            do
            {
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Sub");
                Console.WriteLine("3.Mul");
                Console.WriteLine("4.Div");

                Console.WriteLine("Enter Your Choice");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(num1 + num2);
                        break;
                    case 2:
                        Console.WriteLine(num1 - num2);
                        break;
                    case 3:
                        Console.WriteLine(num1 * num2);
                        break;
                    case 4:
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Invalid Check");
                        break;
                }

                Console.WriteLine("Do you want Continoue");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while
              (ch == 'Y' || ch == 'y');

        }
    }
}

      
