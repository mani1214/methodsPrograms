﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Average1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Average(52423));
        }
        public static int Average(int num)
        {
            int sum = 0;
            int count = 0;
            while (num != 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                count++;
                num /= 10;
            }
            int avg = sum / count;
            return avg;


        }
    }
}
