using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Date in dd/mm/yyyy/ hrs:min:ss AM/PM format: ");
        DateTime date = DateTime.ParseExact(Console.ReadLine() , ("dd/MM/yyyy hrs:min:ss tt") , null);
    }
}