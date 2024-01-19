using System;
namespace CalculatorApplication

{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("First Number: ");
                int firstNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Second Number: ");
                int secondNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Select Operator [ +  ,   -   ,   *   ,   /   ]");

                Console.WriteLine("Operator: ");
                string operation = Console.ReadLine();

                int result = 0;

                if (operation == "+")
                {
                    result = firstNum + secondNum;
                }
                else if (operation == "-")
                {
                    result = firstNum - secondNum;
                }
                else if (operation == "*")
                {
                    result = firstNum * secondNum;
                }
                else if (operation == "/")
                {
                    result = firstNum / secondNum;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

                Console.WriteLine("=============");
                Console.WriteLine(firstNum + " " + operation + " " + secondNum + " = " + result);
                Console.WriteLine("Continue? (Y = Yes, N = No)");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Adios");
            Console.ReadKey();
        }
    }
}