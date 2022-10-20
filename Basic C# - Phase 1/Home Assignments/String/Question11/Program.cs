using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the String:");
        string string1 = Console.ReadLine();
        string string2 = "";
        for(int i=0 ; i<string1.Length ; i++)
        {
            if(!string2.Contains(string1[i]))
            {
                string2 = string2 + string1[i];
            }
        }
        System.Console.WriteLine(string2); 
    }
}