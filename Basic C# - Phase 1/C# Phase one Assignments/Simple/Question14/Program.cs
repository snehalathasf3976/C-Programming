using System;
namespace Question14;
class Program
{
    public static void Main(string[] args)
    {
        for (int i=1 ; i<7 ; i++)
        {
            System.Console.WriteLine("");
            for (int j=1 ; j<=i ;j++)
            {
                System.Console.Write(i);
            }
        }
    }
}