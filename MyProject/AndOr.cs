using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class AndOr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year and Percentage");
            int year = Convert.ToInt32(Console.ReadLine());
            int per = Convert.ToInt32(Console.ReadLine());

            if (year == 2022 && per == 60)
            {
                Console.WriteLine("It is Valid");
            }
            else if (year == 2021 || per > 90)
            {
                Console.WriteLine("It is Also Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }

        }
    }
}
