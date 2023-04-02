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
      Console.WriteLine($"Inter your grade>>");
      double grade = Convert.ToInt32(Console.ReadLine());
      switch (grade)
      {
        case grade >= 90:
          Console.WriteLine($"Your grade {grade}  that is:  A");
          break;
        case grade >= 80:
          Console.WriteLine($"Your grade {grade}  that is:  B");
          break;
        case grade >= 70:
          Console.WriteLine($"Your grade {grade}  that is:  c");
          break;
        default:
          Console.WriteLine($"Your grade {grade}  that is:  Fail");
          break;
      }


    }
  }
}
