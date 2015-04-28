using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] ns = new int[n];
            int un = 0;

            for (int i = 0; i < n; i++)
            {
                ns[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int I = 0; I < n - 1; I++)
                {
                    {
                        if (ns[I] > ns[I + 1])
                        {
                            un = ns[I];
                            ns[I] = ns[I + 1];
                            ns[I + 1] = un;
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ns[i]);
            }
            Console.ReadKey();
        }
    }
}

