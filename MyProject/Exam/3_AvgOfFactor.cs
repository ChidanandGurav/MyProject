using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Exam
{
    internal class _3_AvgOfFactor
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            int count = 0;
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());

            while(num != 0)
            {
                int rem = num% 10;
                count++;
                sum = sum + rem;
                num = num / 10;

            }

            int avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
