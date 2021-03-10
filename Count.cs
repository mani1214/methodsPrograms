using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Count
    {
        public static int Countdigit (int num)
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
        static void Main(string[] args)
        {
            Console.WriteLine(Countdigit(255));
        }
    }
}
