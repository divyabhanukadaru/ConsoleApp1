// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace ConsoleApp1
{
    class Program
    {
        internal int s= 12;
        /*public Program(int a, bool b)
        {
             Console.WriteLine("Hello constructor! values are: "+a+" and "+b);
        }*/
        public Program()
        {
             Console.WriteLine("Hello parent class constructor");
        }
        public void Test1()
        {
             Console.WriteLine("Test1 is called");
        }
        /*static void Main(string[] args)
        {
            Program p1 = new Program(1, true);
            Program p2 = new Program(2, false);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }*/
    }
}
