using System;

namespace FizzBuzz
{
    static class Program
    {
        private static void FizzBuzz()
        {
            int i;

            for (i = 1; i <= 100; i++)
            {
                if (i == 100)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz, ");
                }
                else if ( i % 3 == 0)
                {
                    Console.Write("Fizz, ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz, ");
                }
                else
                {
                    Console.Write($"{i}, ");
                }
            }
        }

        public static void Main()
        {
            FizzBuzz();
        }
    }
}