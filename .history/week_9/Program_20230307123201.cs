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
      string[] friends = new string[5];
      for (int i = 0; i < friends.Length; i++)
      {
        Console.WriteLine("Enter a friend's name:");
        friends[i] = Console.ReadLine();
      }
      Console.WriteLine($" is at index {i}");

    }
  }
}

