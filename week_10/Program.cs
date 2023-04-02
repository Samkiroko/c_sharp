
internal class Program
{
  private static void Main(string[] args)
  {
    Animals animal1 = new Animals("Dog", "Mammal", "Bark");
    Animals animal2 = new Animals("Cat", "Mammal", "Meow");



    Console.WriteLine(animal1.printAnimal());
    Console.WriteLine(animal2.printAnimal());
    Console.WriteLine(animal1.SoundAnimal());

  }

  public class Animals
  {
    string animalName;
    string animalType;
    string animalsSound;



    public Animals(string name, string type, string sound)
    {
      animalName = name;
      animalType = type;
      animalsSound = sound;
    }

    public string printAnimal()
    {
      return $"The {animalName} is a {animalType} and it goes {animalsSound}";
    }

    public string SoundAnimal()
    {
      return $"The {animalName} goes {animalsSound}";
    }
  }
}