using System;
using System.Collections.Generic;

namespace random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> numbers = new List<int> {
                random.Next(9),
                random.Next(9),
                random.Next(9),
                random.Next(9),
                random.Next(9),
                random.Next(9),
            };

            // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
            for (int i=0; i<numbers.Count; i++) {
                if (numbers.Contains(i)) {
                    Console.WriteLine($"Numbers list contains {i}");
                } else {
                    Console.WriteLine($"Numbers list doesn't contain {i}");
                }
            }
        }
    }
}
