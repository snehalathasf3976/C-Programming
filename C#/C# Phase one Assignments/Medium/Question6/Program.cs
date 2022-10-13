using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        int[ , ] matrix1 = new int[3,3];
        int[ , ] matrix2 = new int[3,3];
        System.Console.WriteLine("Enter the Elements of Matrix 1:");
        for(int i=0 ; i<3 ; i++)
        {
            for(int j=0 ; j<3 ; j++)
            {
                System.Console.WriteLine($"Enter [{i}][{j}]: ");
                matrix1[i , j] = int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Enter the Elements of Matrix 2:");
        for(int i=0 ; i<3 ; i++)
        {
            for(int j=0 ; j<3 ; j++)
            {
                System.Console.WriteLine($"Enter [{i}][{j}]: ");
                matrix2[i , j] = int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Addition of Two Matrix is:");
        for(int i=0 ; i<3 ; i++)
        {
            for(int j=0 ; j<3 ; j++)
            {
                System.Console.WriteLine($"[{i}][{j}]: {(matrix1[i , j]+matrix2[i , j])}");
            }
        }
    }
}