using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the String:");
        string string1 = Console.ReadLine();
        System.Console.WriteLine("Enter the Start of Extraction");
        int start = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Length Extraction");
        int length = int.Parse(Console.ReadLine());
        string string2 = "";
        for(int i=start ; i<=length+start ; i++)
        {
            string2 = string2 + string1[i];
        }
        System.Console.WriteLine(string2); 
    }
}