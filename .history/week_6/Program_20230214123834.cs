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
      Console.WriteLine($"Choose 2 to Withdrow");
      Console.WriteLine($"Choose 3 to Send to Mpesa");
      Console.WriteLine($"Choose 4 to Send to Transfer");

      int service = Convert.ToInt32(Console.ReadLine());
      switch (service)
      {
        case 1:
          int deposit = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"You have deposited {deposit}");

          break;
        default:
          break;
      }



    }
  }
}
