public class Program
{
  private static void Main(string[] args)
  {
    GermanShepherd Dog1 = new GermanShepherd();
    GermanShepherd Dog2 = new Chiwawa();
    Dog1.bark();
    Dog1.GSbark();

    Dog2.C
  }

}
// dog class
public class Dogs
{
  // string Breed;
  // int size;

  // float weight;
  // string color;

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


public class Chiwawa : Dogs
{
  public void Chibark()
  {
    Console.WriteLine($"Chi Chhii!!!");

  }

}
