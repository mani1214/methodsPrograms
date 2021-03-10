using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class NumberSet
    {
        static void Main(string[] args)
        {
           Factors(12);
        }

        private static void Factors(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
