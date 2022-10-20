using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("****************");
        int temp=15;
        for(int i=0 ; i<=15 ; i=i+5)
        {
            for(int j=0 ; j<=15 ; j=j+5)
            {
                if(j == 0 || j == 15)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write("       ");
                }
            }
            System.Console.WriteLine("");
        }
        System.Console.WriteLine("****************");
    }
}