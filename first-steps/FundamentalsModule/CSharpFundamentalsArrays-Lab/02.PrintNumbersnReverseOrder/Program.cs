﻿using System;

namespace _02.PrintNumbersnReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLenght = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrLenght];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                
                Console.Write($"{numbers[i]} "); 
            }
        }
    }
}
