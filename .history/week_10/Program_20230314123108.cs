
internal class Program
{
  private static void Main(string[] args)
  {
    Animals animal1 = new Animals("Dog", "Mammal", "Bark");
    Animals animal2 = new Animals("Cat", "Mammal", "Meow");



    Console.WriteLine(animal1.printAnimal());
    Console.WriteLine(animal2.printAnimal());
    Console.WriteLine(animal1.SoundAnimal());
    Console.WriteLine(animal2.SoundAnimal());

  }

  public class Animals
  {
    // string animalName;
    // string animalType;
    // string animalSound;



    public Animals(string name, string type, string sound)
    {
      this.animalName = name;
      this.animalType = type;
      this.animalSound = sound;
    }

    public string printAnimal()
    {
      return $"The {animalName} is a {animalType} and it goes {animalSound}";
    }

    public string SoundAnimal()
    {
      return $"The {animalName} goes {animalSound}";
    }
  }
}