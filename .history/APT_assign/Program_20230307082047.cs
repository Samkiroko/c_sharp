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

        void pattern()
        {
          Console.WriteLine("Enter the number of rows:");
          int rows = Convert.ToInt32(Console.ReadLine());

          for (int i = 1; i <= rows; i++)
          {
            for (int j = 1; j <= i; j++)
            {
              Console.Write("*");
            }
            Console.WriteLine();
          }
          pattern();
        }

      }
    }
  }
}

