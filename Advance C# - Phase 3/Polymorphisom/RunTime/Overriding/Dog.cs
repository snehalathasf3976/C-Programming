namespace Overriding;
public class Dog : Animal
{
    public override void Eat()
    {
        System.Console.WriteLine("Im Dog, So I eat Dog Food");
    }
}