﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrong(153));
        }
        private static bool IsArmstrong(int num)
        {
            int copy = num;
            int sum = 0;
            int count = 0;
            while (num != 0)
            {
                int digit = num % 10;
                count++;
                num /= 10;
            }
            num = copy;
            while (copy != 0)
            {
                int digit = copy % 10;
                int total = powval(digit, count);

                sum = sum + total;

                copy /= 10;
            }

            return num == sum;
        }
        public static int powval(int digit, int count)
        {
            int power = 1;
            for (int i = 1; i <= count; i++)
            {
                power = power * digit;
            }
            return power;
        }
    }
}
