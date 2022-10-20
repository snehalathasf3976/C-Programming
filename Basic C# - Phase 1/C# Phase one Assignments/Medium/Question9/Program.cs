using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        int space=4;
        int temp = 1;
        for(int i=4 ; i>=1 ; i--)
        {
            System.Console.WriteLine("");
            for(int k=space+i-1 ; k>temp ; k--)
            {
                System.Console.Write(" ");
            }
            for(int j=4 ; j>=i ; j--)
            {
                System.Console.Write("* ");
            }
        }
        space=space-2;
        temp=temp+2;
    }
}