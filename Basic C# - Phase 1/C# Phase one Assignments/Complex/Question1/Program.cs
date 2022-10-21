using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int[ ,  ] matrix1 = new int[2,3];
        int[ , ] matrix2 = new int[3,2];
        int[ , ] result = new int[2,2];
        System.Console.WriteLine("Enter the Elements of Matrix 1:");
        for(int i =0 ; i<2 ; i++)
        {
            for(int j=0 ; j<3 ; j++)
            {
                System.Console.WriteLine($"[{i}][{j}] : ");
                matrix1[i,j] = int.Parse(Console.ReadLine());
            }
        }
        for(int i =0 ; i<3 ; i++)
        {
            for(int j=0 ; j<2 ; j++)
            {
                System.Console.WriteLine($"[{i}][{j}] : ");
                matrix2[i,j] = int.Parse(Console.ReadLine());
            }
        }
        for(int i =0 ; i<2 ; i++)
        {
            for(int j=0 ; j<2 ; j++)
            {
                for(int k=0 ; k<3 ; k++)  
                {
                    result[i,j] = result[i,j] + matrix1[i,k] * matrix2[k,j];
                }
            }
        }
        for(int i =0 ; i<2 ; i++)
        {
            for(int j=0 ; j<2 ; j++)
            {
                System.Console.Write(result[i,j]+"\t");
            }
            System.Console.WriteLine("");
        }
    }
}