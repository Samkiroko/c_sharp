
// dog class
public class Dogs
{
  string Breed;
  int size;

  float weight;
  string color;

  public void bark()
  {
    Console.WriteLine($"Dog backs");

  }

  public class GermanShepherd : Dogs
  {
    public void GSbark()
    {
      Console.WriteLine($"I bark wo wo wo!!!");

    }

  }



  private static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");
  }
}