using System;

namespace tapsiriq1
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();

            Substraction substraction = new Substraction();

            Multiplication multiplication = new Multiplication();

            Division division = new Division();

            int n1 =80;
            int n2 = 20;

            Console.WriteLine($"Addition: first number = {n1}, second number = {n2}, result = {addition.Operate(n1,n2)}");
            Console.WriteLine($"Substraction: first number = {n1}, second number = {n2}, result = {addition.Operate(n1, n2)}");
            Console.WriteLine($"Multiplication: first number = {n1}, second number = {n2}, result = {addition.Operate(n1, n2)}");
            Console.WriteLine($"Division: first number = {n1}, second number = {n2}, result = {addition.Operate(n1, n2)}");
        }
    }
}
