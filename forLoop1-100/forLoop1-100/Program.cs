using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop1_100
{
    class Program
    {
        // The purpose of this program is to print numbers from 1 to 100 using the 'for' loop.

        static void Main(string[] args)
        {
            for (int x = 1; x < 101; x++)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
