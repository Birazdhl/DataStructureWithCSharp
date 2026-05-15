using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithm.Recursion
{
    public partial class Recursion
    {
        //Tail Recursion
        public void TailRecursion(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(Math.Pow(n, 2));
                TailRecursion(n - 1);
            }
        }

        //Head Recursion
        public void HeadRecursion(int n)
        {
            if (n > 0)
            {
                HeadRecursion(n - 1);
                Console.WriteLine(Math.Pow(n, 2));
            }
        }

        //Tree Recursion
        public void TreeRecursion(int n)
        {
            if (n > 0)
            {
                TreeRecursion(n - 1);
                Console.WriteLine(Math.Pow(n, 2));
                TreeRecursion(n - 1);
            }
        }

        ////Factorial
        //public int SumOfNumber(int n)
        //{
        //    return n + SumOfNumber(n - 1);
        //}

        //Sum of N Number
        public int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
