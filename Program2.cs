using System;

namespace ConsoleApp1
{

class Program2 : Program
{
   public Program2(int a, bool b)
      {
         Console.WriteLine("Hello constructor! values are: "+a+" and "+b);
      }
   // public Program2()
   // {
   //     Console.WriteLine("Program2 constructer is called");
   // }

   /*
   static void Main(string[] args)
   {
      if (args.Length < 2 || !int.TryParse(args[0], out int a) || !bool.TryParse(args[1], out bool b))
      {
         Console.WriteLine("Please provide valid arguments: <int> <bool>");
         return;
      }

      Program2 p2 = new Program2(a, b);
      p2.Test1();
      Console.WriteLine(p2.s);
   }
   */
}
}
