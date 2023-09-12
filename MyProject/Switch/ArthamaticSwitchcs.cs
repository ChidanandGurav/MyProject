using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Switch
{
    internal class ArthamaticSwitchcs
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 2;
            int no = 0;

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

