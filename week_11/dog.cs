
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
      this.Color = Console.ReadLine();

      Console.Write("Enter the weight of the dog: ");
      int.TryParse(Console.ReadLine(), out int weight);
      this.Weight = weight;

      Console.Write("Enter the size of the dog: ");
      this.Size = Console.ReadLine();

      Console.Write("Enter the breed of the dog: ");
      this.Breed = Console.ReadLine();
    }

    public void Bark()
    {
      Console.WriteLine("Woof woof!");
    }

    public override string ToString()
    {
      return $"Color: {Color}, Weight: {Weight}, Size: {Size}, Breed: {Breed}";
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




