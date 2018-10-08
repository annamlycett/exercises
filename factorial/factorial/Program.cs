using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        //This program is to create a recursive method representing
        //mathematical factorials for positive numbers.

        static int Fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. I'm a factorial calculator.");
            Console.WriteLine("Give me a positive integer:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <1)
            {
                Console.WriteLine("This number is too small. Try a bigger number.");
                Console.WriteLine("Give me a positive integer:");
                num = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("The factorial of {0} is {1}.", num, Fact(num));
            }

            Console.ReadLine();
        }
    }
}
