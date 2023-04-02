using System;

namespace WeekNine
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
      Console.WriteLine(cars.Length);
      Console.WriteLine(cars[0]);

      for (int i = 0; i < cars.Length; i++)
      {
        Console.WriteLine(cars[i]);
      }

      foreach (string car in cars)
      {
        Console.WriteLine(car);
      }

      // print the element and the index in the array
      for (int i = 0; i < cars.Length; i++)
      {
        Console.WriteLine($"{cars[i]} is at index {i}");
      }

      foreach (string car in cars)
      {
        Console.WriteLine($"{car} is at index {Array.IndexOf(cars, car)}");
      }

      // Find avarage of an array
      int[] data = new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 };
      int sum = 0;
      for (int i = 0; i < data.Length; i++)
      {
        sum += data[i];
      }
      Console.WriteLine($"The average is {sum / data.Length}");
    }
  }
}

