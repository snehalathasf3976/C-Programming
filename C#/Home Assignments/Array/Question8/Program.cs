using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Total Number of Rows in Array ");
        int row = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Total Number of Colums in Array");
        int colum= int.Parse(Console.ReadLine());
        int[ , ] array = new int[colum,row];
        int[ , ] array1 = new int[colum,row];
        System.Console.WriteLine("Enter the Elements in the Array 1: ");
        for (int i=0 ; i<colum ; i++)
        {
            for(int j=0 ; j<row ; j++)
            {
                array[i,j] = int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Enter the Elements in the Array 2: ");
        for (int i=0 ; i<colum ; i++)
        {
            for(int j=0 ; j<row ; j++)
            {
                array1[i,j] = int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Array 1 is: ");
        for (int i=0 ; i<colum ; i++)
        {
            for(int j=0 ; j<row ; j++)
            {
                System.Console.WriteLine($"[{i}] , [{j}] is {array[i,j]}");
            }
        }
        System.Console.WriteLine("Array 2 is: ");
        for (int i=0 ; i<colum ; i++)
        {
            for(int j=0 ; j<row ; j++)
            {
                System.Console.WriteLine($"[{i}] , [{j}] is {array1[i,j]}");
            }
        }
        System.Console.WriteLine("Addition of two array is");
        for (int i=0 ; i<colum ; i++)
        {
            for(int j=0 ; j<row ; j++)
            {
                System.Console.WriteLine($"[{i}] , [{j}] is {(array1[i,j]+array[i,j])}");
            }
        }
    }
}