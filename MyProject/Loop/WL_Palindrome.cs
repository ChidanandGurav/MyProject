using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class WL_Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rev = 0;

            while (num != 0)
            {
                int rem =  num % 10;
                rev = ((rev * 10) + rem);
                num = num / 10;
            }
            Console.WriteLine("Number After reverse " + rev);
            if(temp == rev)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is Not palindrome");
            }
        }
    }
}
