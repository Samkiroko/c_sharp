using System;

namespace WeekFive
{
  class ProgramFive
  {
    static void Main(string[] args)
    {

      void gradeChecker()
      {
        Console.WriteLine($"Enter grade");
        double yourGrade = Convert.ToInt32(Console.ReadLine());

        double pass = 50;

        if (yourGrade >= pass)
        {
          Console.WriteLine($"Congratulation you have passed");

        }
        else
        {
          Console.WriteLine($"Sorry you have failed");

        }
      }

    }
  }
}
