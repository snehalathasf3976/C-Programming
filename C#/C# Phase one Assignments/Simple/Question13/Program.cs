using System;
namespace Question13;
class Program
{
    public static void Main(string[] args)
    {
        int product = 1;
        System.Console.WriteLine("Enter the Number");
        int number = int.Parse(Console.ReadLine());
        for(int i=1 ; i<=20 ; i++)
        {
            product = i * number;
            System.Console.WriteLine("{0} * {1} is {2}",number,i,product);
        }
    }
}