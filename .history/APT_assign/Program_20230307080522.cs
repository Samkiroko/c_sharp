using System;

namespace AptAssign
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the first integer number:");
      int num1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the second integer number:");
      int num2 = int.Parse(Console.ReadLine());

      if (num1 > num2)
      {
        Console.WriteLine($"The maximum number is {num1}");
      }
      else
      {
        Console.WriteLine($"The maximum number is {num2}");
      }

      Console.ReadLine();
    }
  }
}

