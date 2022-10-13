using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        int space=4;
        int temp=1;
        int l=1;
        for (int i=0 ; i<=3 ; i++)
        {
            System.Console.WriteLine("");
            
            for ( int k=space+i-1 ; k>0 ; k--)
            {
                System.Console.Write(" ");
            }
            for(int j=0 ; j<=i ; j++ )
            {
                
                System.Console.Write("  "+l);
                l=l+1;
            }
            space = space -2;
            temp = temp +2;
        }
    }
}