using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class VowelConst
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Alphabet");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch== 'a' || ch== 'e' || ch== 'i' || ch== 'o' || ch== 'u')
            {
                Console.WriteLine("Enter Alphabet is Vowel");
            }
            else
            {
                Console.WriteLine("Enter Alphabet is Constant");
            }
        }
    }
}
