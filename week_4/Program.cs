using System;


namespace weekFour
{
  public class FirstClass
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Calculator ");
      Console.WriteLine("________________________________ ");

      /* Adding two numbers*/

      void addTwoNumber()
      {
        Console.WriteLine("Enter the number ");
        int numOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the next number ");
        int numTwo = Convert.ToInt32(Console.ReadLine());
        int total = (numOne + numTwo);
        Console.WriteLine($"The sum of the number is {total}");

      }

      // Multiplying two numbers 
      void multiplyTwoNumber()
      {
        Console.WriteLine("Enter the number ");
        int numOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the next number ");
        int numTwo = Convert.ToInt32(Console.ReadLine());
        int total = (numOne * numTwo);
        Console.WriteLine($"The product of the number is {total}");

      }

      // Dividing two number
      void divisionTwoNumber()
      {
        Console.WriteLine("Enter the number ");
        int numOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the next number ");
        int numTwo = Convert.ToInt32(Console.ReadLine());
        int total = (numOne / numTwo);
        Console.WriteLine($"The division of the number is {total}");

      }
      // Reminder of the two numbers
      void reminderTwoNumber()
      {
        Console.WriteLine("Enter the number ");
        int numOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the next number ");
        int numTwo = Convert.ToInt32(Console.ReadLine());
        int total = (numOne % numTwo);
        Console.WriteLine($"The reminder of the number is {total}");

      }


      void Calculator()
      {
        Console.WriteLine("Choose the operation:   1 = Adding, 2= Multiplication, 3 = division, 4 = modulus");

        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
          addTwoNumber();
        }
        else if (choice == 2)
        {
          multiplyTwoNumber();
        }
        else if (choice == 3)
        {
          divisionTwoNumber();
        }
        else if (choice == 4)
        {
          reminderTwoNumber();
        }
        else
        {
          Console.WriteLine($"Wrong Choice");

        }

      }

      Calculator();


    }



  }
}
