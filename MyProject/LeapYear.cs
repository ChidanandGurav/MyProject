﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine()); 

            if (year % 4 == 0 && year % 100 != 0) 
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Non Leap Year");
            }
        }
    }
}
