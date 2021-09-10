using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Recursion
{
    public class Recursion
    {
        private static Recursion _Instance;
        public static Recursion GetInstance()
        {
            if (_Instance == null)
                _Instance = new Recursion();
            return _Instance;
        }
        public int CalculateFactorial(int n)
        {
            int r = 0;

            //inductive case
            if (n > 1)
                r = n * CalculateFactorial(n - 1);

            //Base case
            if (n == 1)
                r = 1;

            return r;
        }

        public int CalculateFibonacci(int number)
        {
            int r = 0;

            //inductive case
            if (number > 1)
                r = CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2);

            //Base case
            if (number <= 1)
                r = 1;

            return r;
        }

    }
}
