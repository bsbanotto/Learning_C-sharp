using System;

namespace Palindrome
{
    static class Program
    {
        public static void Main()
        {
            Console.WriteLine(Palindrome("Youth"));
        }
        private static bool Palindrome(string str)
        {
            int start = 0;
            int end = str.Length - 1;

            while (start < str.Length / 2)
            {
                if (str[start] != str[end])
                {
                    Console.WriteLine($"{str} is not a palindrome!");
                    return (false);
                }
                start++;
                end--;
            }
            Console.WriteLine($"{str} is a palindrome!");
            return (true);
        }
    }
}