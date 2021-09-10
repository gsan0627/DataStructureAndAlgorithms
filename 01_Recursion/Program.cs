using System;

namespace _01_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Choose one of the options");
            Console.WriteLine("1- Factorial");
            Console.WriteLine("2- Fibonacci ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    number = Recursion.GetInstance().CalculateFactorial(number);
                    Console.WriteLine(number);
                    break;

                case "2":
                    int fibonacci = Recursion.GetInstance().CalculateFibonacci(number);
                    Console.WriteLine("The index {0} belongs to the {1}", number, fibonacci);
                    break;

                default:
                    Console.WriteLine("I did not choose any of the options");
                    break;
            }                      

            Console.ReadKey();            
        }
    }
}
