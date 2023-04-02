
namespace Animal
{
  // dog class
  public class Dog
  {
    public string Color { get; set; }
    public int Weight { get; set; }
    public string Size { get; set; }
    public string Breed { get; set; }

    public Dog(string color, int weight, string size, string breed)
    {
      Color = color;
      Weight = weight;
      Size = size;
      Breed = breed;
    }

    public void Bark()
    {
      Console.WriteLine("Woof woof!");
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



}




