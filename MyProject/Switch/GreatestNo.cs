using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Switch
{
    internal class GreatestNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("No.1 is Greater");
            }
            else if(num2 > num3)
            {
                Console.WriteLine("No.2 is Greater");
            }
            else if(num3 > num1)
            {
                Console.WriteLine("No.3 is Greater");
            }
        }
        
    }
}
