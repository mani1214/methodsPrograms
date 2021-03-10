using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Dig
    {
        public static string Digits(int num)
        {
            string n = string.Empty;
            while (num != 0)
            {
               int  digit = num % 10;
                n = n + digit+",";
                num /= 10;
            }
            return n.Substring(0, n.Length - 1) + ".";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Digits(252));
        }
    }
}
