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
      Console.WriteLine($"Enter your grade>> ");
      int grade = Convert.ToInt32(Console.ReadLine());


    }
  }
}
