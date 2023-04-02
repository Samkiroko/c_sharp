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

      void letterGrade()
      {
        Console.WriteLine("Enter your numeric grade:");
        int numericGrade = Convert.ToInt32(Console.ReadLine());

        char letterGrade;

        switch (numericGrade / 10)
        {
          case 10:
          case 9:
            letterGrade = 'A';
            break;
          case 8:
            letterGrade = 'B';
            break;
          case 7:
            letterGrade = 'C';
            break;
          case 6:
            letterGrade = 'D';
            break;
          default:
            letterGrade = 'F';
            break;
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");
        Console.ReadLine();

      }

      void pattern()
      {
        Console.WriteLine("Pattern A:");
        int rowA = 1;
        while (rowA <= 5)
        {
          int colA = 1;
          while (colA <= rowA)
          {
            Console.Write("*");
            colA++;
          }
          Console.WriteLine();
          rowA++;
        }

        Console.WriteLine("\nPattern B:");
        int rowB = 1;
        while (rowB <= 5)
        {
          int colB = 1;
          while (colB <= 5)
          {
            if (colB <= 5 - rowB)
            {
              Console.Write(" ");
            }
            else
            {
              Console.Write("*");
            }
            colB++;
          }
          Console.WriteLine();
          rowB++;
        }

      }

      void isprime()
      {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int i = 2;
        bool isPrime = true;
        while (i < num)
        {
          if (num % i == 0)
          {
            isPrime = false;
            break;
          }
          i++;
        }
        if (isPrime)
        {
          Console.WriteLine($"{num} is a prime number");
        }
        else
        {
          Console.WriteLine($"{num} is not a prime number");
        }

      }

      void APattern()
      {
        for (int row = 1; row <= 5; row++)
        {
          for (int col = 1; col <= row; col++)
          {
            Console.Write("*");
          }
          Console.WriteLine();
        }
      }
    }
  }
}
