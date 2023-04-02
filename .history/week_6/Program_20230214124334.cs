using System;

namespace WeekSix
{
  public class MyWeekSix
  {
    public static void Main(string[] args)
    {
      /*
      * Switch case
      */
      Console.WriteLine($"Enter your grade>> ");
      int grade = Convert.ToInt32(Console.ReadLine());

      switch (grade)
      {
        case >= 90:
          Console.WriteLine($"Your grade {grade}  that is a :  A");
          break;
        case >= 80:
          Console.WriteLine($"Your grade {grade}  that is a :  B");
          break;
        case >= 70:
          Console.WriteLine($"Your grade {grade}  that is a :  c");
          break;
        case >= 60:
          Console.WriteLine($"Your grade {grade}  that is a :  D");
          break;
        default:
          Console.WriteLine($"Your grade {grade}  that is a :  F");
          break;
      }


      /*_____________________________Exercise two________________________________*/
      Console.WriteLine($"Welcome to ATM >> ");
      Console.WriteLine($"Choose 1 to deposit");
      Console.WriteLine($"Choose 2 to Withdraw");
      Console.WriteLine($"Choose 3 to Send to Mpesa");
      Console.WriteLine($"Choose 4 to Send to Transfer");

      int service = Convert.ToInt32(Console.ReadLine());
      switch (service)
      {
        case 1:
          Console.WriteLine($"Enter amount to Deposit >>");
          int deposit = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"You have deposited {deposit}");
          break;
        case 2:
          Console.WriteLine($"Enter amount to Withdraw >>");
          int Withdraw = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"You have withdrawn {withdraw}");
          break;
        case 2:
          Console.WriteLine($"Enter amount to Mpesa >>");
          int mpesa = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"You have sent  {mpesa} to mpesa");
          break;
        case 2:
          Console.WriteLine($"Enter amount to Transfer >>");
          int transfer = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"You have transfered  {transfer}");
          break;
        default:
          Console.WriteLine($"The service was not successful try again >>");
          int transfer = Convert.ToInt32(Console.ReadLine());
          break;
      }



    }
  }
}
