using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Main String: ");
        string mainString = Console.ReadLine();
        int count = 0;
        foreach(char length in mainString)
        {
            count++;
        }
        System.Console.WriteLine("Length of String is: "+count);
    } 
}