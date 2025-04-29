using System;

namespace ConsoleApp1;

public class Program3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}