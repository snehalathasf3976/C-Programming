using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Total Number of Rows in Array 1");
        int row = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Total Number of Colums in Array1");
        int colum= int.Parse(Console.ReadLine());
        int[ , ] array = new int[colum,row];
        int[ , ] transpose = new int[colum,row];
        System.Console.WriteLine("Enter the Elements in the Array: ");
        for (int i=0 ; i<colum ; i++)
        {
            for(int j=0 ; j<row ; j++)
            {
                array[i,j] = int.Parse(Console.ReadLine());
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
        for (int i=0 ; i<colum ; i++)
        {
            for(int j=0 ; j<row ; j++)
            {
                int[ , ] temp = new int[colum,row];
                temp[i,j] = array[i,j];
                array[i , j] = array[j,i];
                array [j,i] = temp[i,j];

            }
        }
        for (int i=0 ; i<colum ; i++)
        {
            for(int j=0 ; j<row ; j++)
            {
                transpose[j , i] = array[i , j];
            }
        }
        System.Console.WriteLine("Transeponse Array is: ");
        for (int i=0 ; i<colum ; i++)
        {
            System.Console.WriteLine("");
            for(int j=0 ; j<row ; j++)
            {
                System.Console.Write(" "+transpose[i , j]);
            }
        }
    }
}