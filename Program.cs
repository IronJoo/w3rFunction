using System;

namespace w3rFunction //{}
{
    class Exercise3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Function to calculate the sum of two numbers:\n--------");
            Console.WriteLine("Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("The sum of {0} + {1} is {2}.", num1, num2, Sum(num1, num2));

            Console.ReadLine();
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
