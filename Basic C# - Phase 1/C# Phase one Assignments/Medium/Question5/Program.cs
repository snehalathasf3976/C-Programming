using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Value of N: ");
        int year = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Leap Years are: ");
        for(int i=1 ; i<=year ; i++)
        {
            if(i%4 == 0 && i%100 != 0)
            {
                System.Console.Write("\t"+i);
            }
        }
    }
}