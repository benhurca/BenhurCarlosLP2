using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n, r;
            n = 1;
            k = -1;
            r = 0;

            while (n != 0)
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                r = n + r;
                k++;
            }
            r = r / k;

            Console.WriteLine(r);
            Console.ReadKey();

        }
    }
}
