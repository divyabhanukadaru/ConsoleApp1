using System;

namespace ConsoleApp1;

public class Program3
{
    public static int SumOfThreeNumbers(int a, int b, int c)
    {
        return a + b + c;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers to sum:");
        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Third number: ");
        int thirdNumber = int.Parse(Console.ReadLine() ?? "0");
        int result = SumOfThreeNumbers(firstNumber, secondNumber, thirdNumber);
        Console.WriteLine($"The sum of {firstNumber}, {secondNumber}, and {thirdNumber} is: {SumOfThreeNumbers(firstNumber, secondNumber, thirdNumber)}");
        ConsoleApp1.Readline();
    }
}