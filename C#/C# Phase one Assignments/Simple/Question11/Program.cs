using System;
namespace Question11;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Base Value");
        int number = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Power Value");
        int number1 = int.Parse(Console.ReadLine());
        int product =number;
        for (int i=1 ;i<number1 ; i++)
        {
            product = product * number;
        }
        System.Console.WriteLine("{0}^{1} is {2}",number,number1,product);
    }
}