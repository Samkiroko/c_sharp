
namespace Animal
{
  // dog class
  public class Dog
  {
    public string Color { get; set; }
    public int Weight { get; set; }
    public string Size { get; set; }
    public string Breed { get; set; }

    public Dog()
    {
      Console.Write("Enter the color of the dog: ");
      Color = Console.ReadLine();

      Console.Write("Enter the weight of the dog: ");
      int.TryParse(Console.ReadLine(), out int weight);
      Weight = weight;

      Console.Write("Enter the size of the dog: ");
      Size = Console.ReadLine();

      Console.Write("Enter the breed of the dog: ");
      Breed = Console.ReadLine();
    }

    public void Bark()
    {
      Console.WriteLine("Woof woof!");
    }

    public void Print()
    {
      Console.WriteLine($"The dog detail are color is {color} weight is {weight} size is {size} breed is {breed}");

    }
  }



  public class GermanShepherd : Dog
  {
    public void GSbark()
    {
      Console.WriteLine($"I bark wo wo wo!!!");

    }

  }


  public class Chiwawa : Dog
  {
    public void Chibark()
    {
      Console.WriteLine($"Chi Chhii!!!");

    }

  }



}




