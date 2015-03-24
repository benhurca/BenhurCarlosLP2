using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int r = 0;
            ArrayList ns = new ArrayList();

            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());

                r = r + n;

                if (n > 0)
                {
                    ns.Add(n);
                }

            }

            r = r / ns.Count;

            Console.WriteLine(r);
            Console.ReadKey();

        }
    }
}

