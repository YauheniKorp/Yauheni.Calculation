﻿using System;


namespace Yauheni.Calculation
{
    class Program
    {
        static void Main()
        {
            Calculation();
            Select();
        }
         static double GetNumber()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        static string GetAction()
        {
            string Action = Convert.ToString(Console.ReadLine());
            return Action;
        }
        static void Select()

        {
            Console.WriteLine($"Do you want to continue? Enter Yes or No");
            string u = Convert.ToString(Console.ReadLine());
            u.ToLower();
            if (u == "yes")
            {
                Calculation();
            }
            else
            {
                Console.WriteLine($"GoodBye");
                return;
            }
            Console.ReadLine();
        }
        static void Calculation()
        {
           Console.WriteLine($"Enter the first number");
           double FirstNumber = GetNumber();
           Console.WriteLine($"Enter the second number: ");
           double SecondNumber = GetNumber();
           Console.WriteLine($"Select an action: +, -, *, /");
           string selection = GetAction();
           switch (selection)
            {
                case "+":
                    double result = FirstNumber + SecondNumber;
                    Console.WriteLine(result);
                    break;
                case "-":
                    double result1 = FirstNumber - SecondNumber;
                    Console.WriteLine(result1);
                    break;
                case "*":
                    double result2 = FirstNumber * SecondNumber;
                    Console.WriteLine(result2);
                    break;
                case "/":
                    double result3 = FirstNumber / SecondNumber;
                    Console.WriteLine(result3);                    
                    break;
            }   
        }
    }
}
