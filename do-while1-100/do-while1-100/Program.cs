using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 101);
            Console.ReadLine();
        }
    }
}
