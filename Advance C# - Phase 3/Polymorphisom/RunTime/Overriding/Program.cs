using System;
namespace Overriding;
class Program
{
    public static void Main(string[] args)
    { 
        Animal animal = new Animal();
        animal.Eat();

        Dog lab = new Dog();
        lab.Eat();

        Pomerian dog = new Pomerian();
        dog.Eat();
    }
}