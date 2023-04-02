using System;
namespace Assign
{
  public class MyClass
  {
    public static void Main(string[] args)
    {
      void add(int a, int b)
      {
        int c = a + b;
        Console.WriteLine("Sum of two numbers is: " + c);
      }
      add(10, 20);
    }
  }
}
