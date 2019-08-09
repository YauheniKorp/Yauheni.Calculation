using System;

namespace Yauheni.Calculation
{
    class Program
    {
        static void Main()

        {
            Calc();


            void Calc()
            {
                Console.WriteLine($"Enter the first number: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter the second number:  ");
                int y = Convert.ToInt32(Console.ReadLine());




                Console.WriteLine($"Select an action: +, -, *, /");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "+":

                        int result = x + y;
                        Console.WriteLine(result);
                        goto case "5";
                    case "-":
                        int result1 = x - y;
                        Console.WriteLine(result1);
                        goto case "5";
                    case "*":
                        int result2 = x * y;
                        Console.WriteLine(result2);
                        goto case "5";
                    case "/":
                        int result3 = x / y;
                        Console.WriteLine(result3);
                        goto case "5";
                    case "5":

                        Console.WriteLine($"Do you want to continue? Enter Yes or No");
                        string u = Convert.ToString(Console.ReadLine());

                        if (u == "Yes")
                        {
                            Calc();

                        }
                        else
                        {
                            Console.WriteLine($"GoodBye");
                            return;
                        }
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
