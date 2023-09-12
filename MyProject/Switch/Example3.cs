using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Switch
{
    internal class Example3
    {
        static void Main(string[] args)
        {
            int r = 2;
            int l = 3;
            int b = 5;
            int h = 2;
            double pi = 3.14;

            int no = 0;
            do
            {
                Console.WriteLine("1.Squre");
                Console.WriteLine("2.Rectangular");
                Console.WriteLine("3.Circle");
                Console.WriteLine("4''''''''''''''''''''''''.Traingle");

                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(r*r);
                        break;
                    case 2:
                        Console.WriteLine(l*b);
                        break;
                    case 3:
                        Console.WriteLine(3.14*r*r);
                        break;
                    case 4:
                        Console.WriteLine(1.5*b*r);
                        break;
                        case 5:
                        Console.WriteLine("Invalid Check");
                        break;

                }

                Console.WriteLine("Press 0 for Continoue");
                no = Convert.ToInt32(Console.ReadLine());   
            }
            while (no == 0);
        }
    }
}
