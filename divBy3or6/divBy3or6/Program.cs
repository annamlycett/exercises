using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divBy3or6
{
    //Goal: to print numbers 1-100. If a number is divisible by 3 or 6,
    //the console should print "divisible by 3" or "divisible by 6" as well.

    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 101; x++)
            {
                if (x % 3 != 0)
                {
                    Console.WriteLine(x);
                }

                else if (x % 6 == 0)
                {
                    Console.WriteLine("{0} - divisible by 6", x);
                }

                else
                {
                    Console.WriteLine("{0} - divisible by 3", x);
                }
            }

            Console.ReadLine();
        }
    }
}
