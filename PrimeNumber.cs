using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(9));
        }
        public static bool IsPrime(int num)
        {
            int count = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            return count == 1;
        }
    }
}
