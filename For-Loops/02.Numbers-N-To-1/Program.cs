﻿namespace _02.Numbers_N_To_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int pow = 0; pow <= n; pow+= 2)
            {
                Console.WriteLine(Math.Pow(2, pow));

            }
        }
    }
}