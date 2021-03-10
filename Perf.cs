using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Perf
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfect(28));
        }
        public static bool IsPerfect(int num)
        {
            return num == Factors(num);
        }

        public static int Factors(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
  
}
