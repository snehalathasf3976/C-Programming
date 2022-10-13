using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter String One: ");
        string stringOne = Console.ReadLine();
        string name = "";
        for(int i=0 ; i<stringOne.Length ; i++)
        {
            if(!name.Contains(stringOne[i]))
            {
                name = name + stringOne[i];
            }
        }
        System.Console.WriteLine(name);
    }
}