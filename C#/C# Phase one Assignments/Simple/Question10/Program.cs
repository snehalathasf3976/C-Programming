using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Character");
        char check = char.Parse(Console.ReadLine());
        if (check == 'a' || check == 'e' || check == 'i' || check == 'o'|| check == 'u')
        {
            System.Console.WriteLine("Vowels");
        }
        else
        {
            System.Console.WriteLine("Not Vowels");
        }
    }
}