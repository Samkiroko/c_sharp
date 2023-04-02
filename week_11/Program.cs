using Animal;




public class Program
{
  private static void Main(string[] args)
  {
    Dog myDog = new Dog();
    Console.WriteLine(myDog.ToString()); // Outputs: "Color: Brown, Weight: 10, Size: Small, Breed: Poodle"
    myDog.Bark(); // Outputs: "Woof woof!"

  }

}

