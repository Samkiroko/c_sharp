﻿using System;

namespace WeekSix
{
  public class MyWeekSix
  {
    public static void Main(string[] args)
    {
      /*
      * Switch case
      */
      Console.WriteLine($"Enter your grade>>");
      int grade = Convert.ToInt32(Console.ReadLine());

      switch (grade)
      {
        case >= 90:
          Console.WriteLine($"Your grade {grade}  that is:  A");
          break;
        case >= 80:
          Console.WriteLine($"Your grade {grade}  that is:  B");
          break;
        case >= 70:
          Console.WriteLine($"Your grade {grade}  that is:  c");
          break;
        default:
          Console.WriteLine($"Your grade {grade}  that is:  Fail");
          break;
      }


    }
  }
}
