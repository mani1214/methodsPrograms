using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Separte
    {
        public static int Rev(int num)
        {
            int rev = 0;
            while (num != 0)
            {
                int digit = num % 10;
                rev = rev*10 + digit;
                num /= 10;
            }
            return rev;
        }
        public static bool IsPlaindrome(int num)
        {
            return num == Rev(num);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPlaindrome(121));
        }
    }
}
