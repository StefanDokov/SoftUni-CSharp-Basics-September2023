﻿using System;

namespace OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operant = Console.ReadLine();
            string evenOrOdd = "";

            double result = 0;

            if (operant == "+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {operant} {n2} = {result} - {evenOrOdd}");
            }
            if (operant == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {operant} {n2} = {result} - {evenOrOdd}");

            }
            if (operant == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {operant} {n2} = {result} - {evenOrOdd}");

            }
            if (operant == "/")
            {
                
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 / n2;
                    Console.WriteLine($"{n1} {operant} {n2} = {result:f2}");

                }

            }
            if (operant == "%")
            {

                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} {operant} {n2} = {result}");

                }

            }


        }
    }
}
