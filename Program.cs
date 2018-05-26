using System;

/* Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print "Invalid number". 
In all cases finally print "Good bye". Use try-catch-finally.

Напишите программу, которая читает целое число, вычисляет и печатает его квадратный корень.
Если число недействительно или отрицателное, напечатайте «Invalid number».
Во всех случаях в блоке finally напечатайте «Good bye». Используйте try-catch-finally. */

namespace _20180306_Task1_Exception
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter a positive integer: ");

            try
            {
                bool isInt = int.TryParse(Console.ReadLine(), out int number);
                if (isInt != true || number < 0)
                {
                    throw new Exception("Invalid number");
                }
                Console.WriteLine("The square root is: " + Math.Sqrt(number));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

            Console.ReadKey();
        }
    }
}