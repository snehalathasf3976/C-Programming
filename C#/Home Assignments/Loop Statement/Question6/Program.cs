using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        for(int i=0 ; i<5 ; i++)
        {
            System.Console.WriteLine("");
            for(int j=0 ; j<i ; j++)
            {
                System.Console.Write("*");
            }
        }
    }
}