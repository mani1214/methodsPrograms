using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class SumMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Average(125));
        }

        private static int Sum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num /= 10;
            }
            return sum;
        }
        public static int  Average(int num)
        {
            int avg = Sum(num)/Count(num);
              return avg;
            
    }
        public static int Count(int num)
        {
            int count = 0;
            while (num != 0)
            {
                int digit = num % 10;
                count++;
                num /= 10;
            }
            return count;
        }
    }
}
