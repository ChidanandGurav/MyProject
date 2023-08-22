using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class percentage
    {
        static void Main(string[] args)
        {
            int phy, che, math, total;
            double per;
            Console.WriteLine("Enter marks of three SUbject");
            phy = Convert.ToInt32(Console.ReadLine());
            che = Convert.ToInt32(Console.ReadLine());
            math = Convert.ToInt32(Console.ReadLine());
            total = phy + che + math;
            Console.WriteLine(total);

            per = total / 3;
            Console.WriteLine(per);

            if (per > 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (per > 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (per > 60)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade D");
            }

        }
    }
}