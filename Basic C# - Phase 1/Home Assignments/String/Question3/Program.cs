using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Main String: ");
        string mainString = Console.ReadLine();
        for (int i=mainString.Length - 1 ; i>=0 ;i--)
        {
            System.Console.Write(mainString[i]);
        }
    }
}