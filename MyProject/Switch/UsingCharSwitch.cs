using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Switch
{
    internal class UsingCharSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first No.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second No.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int no = 0;

            do
            {

                Console.WriteLine("+.Add");
                Console.WriteLine("-.Sub");
                Console.WriteLine("*.Mul");
                Console.WriteLine("/.Div");

                Console.WriteLine("Enter Your Choice");
                int choice =Convert.ToChar(Console.ReadLine());

                switch (choice)
                {
                    case '+':
                        Console.WriteLine(num1 + num2);
                        break;

                    case '-':
                        Console.WriteLine(num1 - num2);
                        break;

                    case '*':
                        Console.WriteLine(num1 * num2);
                        break;

                    case '/':
                        Console.WriteLine(num1 / num2);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }


                Console.WriteLine("press 0 for Continue");
                no = Convert.ToInt32(Console.ReadLine());
            }

            while (no == 0);
        }

    }
}
