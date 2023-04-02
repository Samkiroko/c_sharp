using System;

namespace Chapter
{
  public class MyClass
  {
    private const string Value = "Enter a positive number  ";

    public static void Main()
    {

      //  -------------------------------Logical Operator ^ and !--------------------------------------------

      Console.WriteLine("Exclusive OR: " + ((2 < 3) ^ (4 > 3)));

      //__________________________________________Loops____________________________________________________
      /*
      - A loop is abasic programming construct that allows repeated execution of a fragment of source code.
      - Loop will repeat until the given condition is true (EXISTS)
      */

      //__________________________________________While Loops____________________________________________________
      /*
      
      while (condition)
      {
        loop body;
      }

      - Condition will return true or false
      */

      // int time = 5;
      // int start_time = 0;

      // while (start_time != time)
      // {
      //   start_time += 1;
      //   Console.WriteLine($"{start_time}");

      // }

      // _______________________________________
      // Console.Write("n = ");
      // int n = int.Parse(Console.ReadLine());
      // int num = 1;
      // int sum = 1;
      // Console.Write("The sum 1");
      // while (num < n)
      // {
      //   num++;
      //   sum += num;
      //   Console.Write(" + " + num);
      // }
      // Console.WriteLine(" = " + sum);

      // ________________________ Prime number ______________________

      // Console.WriteLine(Value);

      // int num = Convert.ToInt32(Console.ReadLine());
      // int divider = 2;
      // int maxDivider = (int)Math.Sqrt(num);
      // bool prime = true;
      // while (prime && (divider <= maxDivider))
      // {
      //   if (num % divider == 0)
      //   {
      //     prime = false;
      //   }
      //   divider++;
      // }
      // Console.WriteLine($"Prime? {prime} ");




      // __________________ Factorial Calculation ___________
      // int n = Convert.ToInt32(Console.ReadLine());
      // decimal factorial = 1;
      // while (true)
      // {
      //   if (n <= 1)
      //   {
      //     break;
      //   }
      //   factorial *= n;
      //   n--;
      // }
      // Console.WriteLine("n! = " + factorial);


      // ______________ Calculating Factorial _______________

      // Console.WriteLine($"n = ");
      // int n2 = Convert.ToInt32(Console.ReadLine());
      // decimal factorial2 = 1;

      // do
      // {
      //   factorial2 *= n2;
      //   n2--;
      // } while (n2 > 0);
      // Console.WriteLine($"n! = {factorial2}");


      //  _______________ Product in the Range [N___M] - Example

      // Console.Write("N = ");
      // int N = Convert.ToInt32(Console.ReadLine());

      // Console.Write("M = ");
      // int M = Convert.ToInt32(Console.ReadLine());

      // int num2 = N;
      // long Product = 1;

      // do
      // {
      //   Product *= num2;
      //   num2++;
      // } while (num2 <= M);
      // Console.WriteLine($"Product [{N}...{M}] = {Product}");

      // ___________________ For Loop ____________

      // for (int i = 0; i <= 10; i++)
      // {
      //   Console.Write($"{i} ");
      // }


      // _________________________ TWO INIT VARIABLES _____________________
      // for (int i = 1, sum = 1; i <= 128; i *= 2, sum += i)
      // {
      //   Console.WriteLine($"i = {i}, Sum = {sum} ");
      // }

      // ____________________ Loop with several variables _________________
      // for (int small = 1, large = 10; small < large; small++, large--)
      // {
      //   Console.WriteLine($"{small} {large}");
      // }


      // ________________ Continue _______________________________________
      // int n = Convert.ToInt32(Console.ReadLine());
      // int total = 0;
      // for (int i = 1; i <= n; i += 2)
      // {
      //   if (i % 7 == 0)
      //   {
      //     continue;
      //   }
      //   total += i;
      // }
      // Console.WriteLine($"Sum = {total}");

      // _________ for each Loop ________

      /*
      
      
      for (type variable in collection)
      {
        statements
      }
      
      
      */
      // int[] numbers = { 2, 3, 4, 5, 6, 7 };
      // foreach (int i in numbers)
      // {
      //   Console.Write($"{i} ");

      // }

      // __________ nested loop ____________________
      int n = Convert.ToInt32(Console.ReadLine());
      for (int row = 1; row <= n; row++)
      {
        for (int col = 1; col <= row; col++)
        {
          Console.Write($"{col} ");

        }
        Console.WriteLine();

      }
    }
  }
}
