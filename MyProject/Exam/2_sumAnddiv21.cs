using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Exam
{
    internal class _2_sumAnddiv21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int a = num;

             while(num > 0)
             {
                 int digit = num % 10;
                 sum = sum + digit;
                 num = num / 10;
             }
             Console.WriteLine(sum);

            if (a % sum == 0) 
            {
                Console.WriteLine("It is a harshad");
            }
  

        }
    }
}
