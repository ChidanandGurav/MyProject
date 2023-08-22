using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class WL_sumofdigit
    {
        static void Main(string[] args)
        {
            /* int num = 123;
             int sum = 0;

             while(num > 0)
             {
                 int digit = num % 10;
                 sum = sum + digit;
                 num = num / 10;
             }

             Console.WriteLine(sum);*/

            Console.WriteLine("Enter Number"); // user
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while(num > 0)
            {
                int digit = num% 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
