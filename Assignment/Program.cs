using System;

namespace Assignment
{
  public class MyAssignment
  {
    static void Main()
    {

      // Write a C# Sharp program to print Hello and your name in a separate line

      void greetings()
      {
        string name = "Samuel";

        Console.WriteLine($"Hello {name}");


      }

      // Write a C# Sharp program to print the sum of two numbers

      void sumOfTwoNumber()
      {
        Console.WriteLine($"Enter first number");

        int numOne = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter Second number");

        int numTwo = Convert.ToInt32(Console.ReadLine());

        int total = numOne + numTwo;
        Console.WriteLine($"The sum of the two numbers {total}");

      }

      // Write a C# Sharp program to print the result of dividing two numbers.

      void divisionOfTwoNumber()
      {
        Console.WriteLine($"Enter first number");

        int numOne = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter Second number");

        int numTwo = Convert.ToInt32(Console.ReadLine());

        double total = numOne / numTwo;
        Console.WriteLine($"The division of the two numbers {total}");

      }

      // Write a C# Sharp program to print the result of the specified operations.

      void operation()
      {
        Console.WriteLine(-1 + 4 * 6);
        Console.WriteLine((35 + 5) % 7);
        Console.WriteLine(14 + -4 * 6 / 11);
        Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
      }

      // Write a C# Sharp program that takes four numbers as input to calculate and print the average.
      void averageCalculator()
      {
        Console.WriteLine("Enter four numbers: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());
        double num4 = Convert.ToDouble(Console.ReadLine());

        double average = (num1 + num2 + num3 + num4) / 4;

        Console.WriteLine("The average is: " + average);
      }

      void lookOlder()
      {
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("You look older than " + age);

      }

      // greetings();
      // sumOfTwoNumber();
      // divisionOfTwoNumber();
      // operation();

      averageCalculator();
    }
  }
}
