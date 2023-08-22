using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Areaoftriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Side");
            int a = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            result = (1.5 / 4) * (a * a);

            Console.WriteLine("Area of equilateral triangle : " + result);
        }
    }
}
