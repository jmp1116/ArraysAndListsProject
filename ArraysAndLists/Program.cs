using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();
            var odds = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)  evens.Add(num);
                else if (num % 2 != 0) odds.Add(num);

            }
            
            foreach (int num in evens)
            {
                Console.WriteLine(num);
            }

            foreach (int num in odds)
            {
                Console.WriteLine(num);
            }


            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
