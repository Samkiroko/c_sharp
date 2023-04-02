
internal class Program
{
  private static void Main(string[] args)
  {
    Animals animal1 = new Animals("Dog", "Mammal", "Bark");

    Console.WriteLine(animal1.printAnimal());
  }

  public class Animals
  {
    string animalName;
    string animalType;
    string animalSound;



    public Animals(string name, string type, string sound)
    {
      animalName = name;
      animalType = type;
      animalSound = sound;
    }

    public string printAnimal()
    {
      return $"The {animalName} is a {animalType} and it goes {animalSound}";
    }
  }
}