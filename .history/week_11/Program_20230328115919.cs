public class Program
{
  private static void Main(string[] args)
  {
    GermanShepherd Dog1 = new GermanShepherd();
    Dog1.bark();
    Dog1.GSbark();
  }

}
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


}



public class GermanShepherd : Dogs
{
  public void GSbark()
  {
    Console.WriteLine($"I bark wo wo wo!!!");

  }

}

