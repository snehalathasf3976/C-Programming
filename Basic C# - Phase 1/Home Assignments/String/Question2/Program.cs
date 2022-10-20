using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Main String: ");
        string mainString = Console.ReadLine();
        foreach(char letter in mainString)
        {
            System.Console.Write(letter+" ");
        }
    }
}