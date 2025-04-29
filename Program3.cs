using System;

namespace ConsoleApp1;

public class Program3
{
    public static int FindSquare(int number)
    {
        return number * number;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to find its square:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            int square = FindSquare(number);
            Console.WriteLine($"The square of {number} is {square}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        
    }
}