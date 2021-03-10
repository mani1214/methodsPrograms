using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class AverageFactor
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(AverageOfFactors(12));
        }
        public static int AverageOfFactors(int num)
        {
            int count = 0;
            int sum = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
            int avg = sum / count;
            return avg;
        }
    }
}
