﻿using System;

namespace Logicalprograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a Number : ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int k;
            k = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                Console.WriteLine("Entered Number is a Prime Number ");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();

        }

    }
}