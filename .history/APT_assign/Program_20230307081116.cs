using System;

namespace AptAssign
{
  class Program
  {
    static void Main(string[] args)
    {
      void maximum()
      {
        Console.WriteLine("Enter the first integer number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
          Console.WriteLine($"The maximum number is {num1}");
        }
        else
        {
          Console.WriteLine($"The maximum number is {num2}");
        }

      }

      void maximum2()
      {
        Console.WriteLine("Enter the first integer number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer number:");
        int num2 = int.Parse(Console.ReadLine());

        int max = num1;
        if (num2 > num1)
        {
          max = num2;
        }

        Console.WriteLine($"The maximum number is {max}");
        Console.ReadLine();
      }


    }
  }
}

