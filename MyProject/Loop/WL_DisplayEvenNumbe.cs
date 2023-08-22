using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class WL_DisplayEvenNumbe
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int sum = 0;

            while (num > 0)
            {
                int rem = num% 10;
                num = num/10;

                if(rem % 2 == 0) 
                {
                    //sum = sum+ rem; // sum of even number
                    Console.WriteLine(rem); // only find even number
                }
            }

            
        }
    }
}
