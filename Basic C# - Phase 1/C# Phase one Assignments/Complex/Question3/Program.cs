using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter String One: ");
        string stringOne = Console.ReadLine();
        System.Console.WriteLine("Enter String One: ");
        string stringTwo = Console.ReadLine();
        bool check = true;
        if(stringOne.Length == stringTwo.Length)
        {
            for(int i=0 ; i<stringOne.Length ; i++)
            {
                check = check && stringOne.Contains(stringTwo[i]);
            }
            if(check)
            {
                System.Console.WriteLine("Name One and Two are Anagram");
            }
            else
            {
                System.Console.WriteLine("Not Anagram");
            }
        }
        else
        {
            System.Console.WriteLine("Not Anagram");
        }
    }
}