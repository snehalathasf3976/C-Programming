using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number");
        int total=0 ;
        for (int i=0 ; i<10 ; i++)
        {
            //System.Console.WriteLine("");
            int j = int.Parse(Console.ReadLine());
            total = total + j;
        }
        double average = (double) total/10;
        System.Console.WriteLine("Total is: "+total);
        System.Console.WriteLine("Average is: "+average);
    }
}