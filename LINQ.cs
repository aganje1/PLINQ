using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        public const long N = 1000000000;
        static void Main(string[] args)
        {
            long[] list = new long[N];

            Random rand = new Random();
            int i;

            for (i = 0; i < N - 1; i++)
            {
                list[i] = rand.Next(0, 1001);
            }

            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            IEnumerable<long> query =
                from element in list
                where element >= 4 && element <= 350
                select element;

            watch.Stop();

            Console.WriteLine($"QuickSort Execution Time: {watch.ElapsedMilliseconds} ms.");
            Console.WriteLine($"QuickSort Execution Time: {watch.ElapsedMilliseconds * 1000000} ns.");

            Console.WriteLine("Would you like to print list? Type Y/N.");
            string printVar = Console.ReadLine();
            if (printVar == "Y" || printVar == "y")
            {
                foreach (int value in query)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
