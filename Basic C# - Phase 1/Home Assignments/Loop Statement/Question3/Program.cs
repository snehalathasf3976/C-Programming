using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number of Terms");
        int terms = int.Parse(Console.ReadLine());
        for (int i=1 ; i<=terms ; i++)
        {
            System.Console.WriteLine("Number is {0} and the Cube of {1} is {2}",i,i,(i*i*i));
        }
    }
}