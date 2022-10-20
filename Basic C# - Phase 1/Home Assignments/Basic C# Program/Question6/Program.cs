using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the total amount of the Product");
        int price = int.Parse(Console.ReadLine());
        double total = (double) price+price * 0.18;
        System.Console.WriteLine("Total Price of the Product is: "+total);
    }
}