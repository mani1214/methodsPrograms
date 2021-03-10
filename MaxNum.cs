using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MaxNum
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(MaxDigitNumber(292617));
        }
        public static int MaxDigitNumber(int num)
        {
            int max = num % 10;
            while (num != 0)
            {
                int digit = num % 10;
                if (digit > max)
                {
                    max = digit;
                }
                num /= 10;
            }
            return max;
        }
    }
}
