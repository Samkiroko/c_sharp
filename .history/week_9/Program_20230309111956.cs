using System;

namespace WeekNine
{
  class Program
  {
    static void Main(string[] args)
    {
      // string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
      // Console.WriteLine(cars.Length);
      // Console.WriteLine(cars[0]);

      // for (int i = 0; i < cars.Length; i++)
      // {
      //   Console.WriteLine(cars[i]);
      // }

      // foreach (string car in cars)
      // {
      //   Console.WriteLine(car);
      // }

      // print the element and the index in the array
      // for (int i = 0; i < cars.Length; i++)
      // {
      //   Console.WriteLine($"{cars[i]} is at index {i}");
      // }

      // foreach (string car in cars)
      // {
      //   Console.WriteLine($"{car} is at index {Array.IndexOf(cars, car)}");
      // }

      // Find average of an array
      // int[] data = new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 };
      // int sum = 0;
      // for (int i = 0; i < data.Length; i++)
      // {
      //   sum += data[i];
      // }
      // Console.WriteLine($"The average is {sum / data.Length}");

      // input five friends and output the length and the corresponding indexes
      // string[] friends = new string[5];
      // for (int i = 0; i < friends.Length; i++)
      // {
      //   Console.WriteLine("Enter a friend's name:");
      //   friends[i] = Console.ReadLine();
      // }
      // foreach (string friend in friends)
      // {
      //   Console.WriteLine($"{friend} is at index {Array.IndexOf(friends, friend)}");
      //   Console.WriteLine($"The length of the array is {friends.Length}");
      // }
      // input five grades into array and output the  the length and the corresponding indexes
      // int[] grades = new int[5];
      // for (int i = 0; i < grades.Length; i++)
      // {
      //   Console.WriteLine("Enter a grade:");
      //   grades[i] = Convert.ToInt32(Console.ReadLine());
      // }
      // foreach (int grade in grades)
      // {
      //   Console.WriteLine($"{grade} is at index {Array.IndexOf(grades, grade)}");
      //   Console.WriteLine($"The length of the array is {grades.Length}");
      // }

      int[] data1 = { 1, 2, 3, 4, 5, 6, 7 };
      int[] data2 = { 8, 9, 10, 11, 12, 13, 14 };

      CopyIt(data1, data2);

      Console.Write("data1");
      for (int i = 0; i < data1.Length; i++)
      {
        Console.WriteLine($"{data1}");
        Console.WriteLine();
      }

      Console.Write("data2");
      for (int i = 0; i < data2.Length; i++)
      {
        Console.WriteLine($"{data2}");
        Console.WriteLine();
      }
      static void CopyIt(int[] from, int[] to)
      {
        for (int i = 0; i < from.Length; ++i)
        {
          to[i] = from[i];
        }
      }


    }
  }
}

