// See https://aka.ms/new-console-template for more information
using Polyorphism_Abstraction.InheritancePolymorphism;

Console.WriteLine("Hello, World!");


Animal anAnimal = new Animal();
Console.WriteLine(anAnimal.Eat());
Console.WriteLine(anAnimal.Move());
Console.WriteLine(anAnimal.Speak());

//UpCasting ,,Base Class Reference and Child Class Object
Animal anAnimal1 = new Eagle();


//DownCasting ,,Child Class Reference and Base Class Object
Eagle anEagle = (Eagle)anAnimal1;
Console.WriteLine(anEagle.Fly());

Console.WriteLine(anAnimal1.Eat());
Console.WriteLine(anAnimal1.Move());
Console.WriteLine(anAnimal1.Speak());
Console.WriteLine("...........");
List<Animal> zoo = new List<Animal>();
zoo.Add(anAnimal1);
zoo.Add(new Hen());
zoo.Add(new HummingBird());
zoo.Add(new Duck());
zoo.Add(new Tiger());
//zoo.Add(new Animal());
foreach(var animal in zoo)
{
    Console.WriteLine(animal.Speak());
}  
    







