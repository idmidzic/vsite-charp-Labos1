using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi djeljivi s 3:");
            for (int idx = 1; idx < 100; ++idx)
            {
                if (idx % 3 == 0)
                {
                    Console.WriteLine(idx);
                }
            }
            Console.WriteLine("Gotovo!");
        }
    }
}

