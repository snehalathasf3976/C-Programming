using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Total Number of inputs");
        int total = int.Parse(Console.ReadLine());
        int[ , ] array = new int[total,total];
        System.Console.WriteLine("Enter the Elements in the Array: ",total);
        for (int i=0 ; i<total ; i++)
        {
            for(int j=0 ; j<total ; j++)
            {
                array[i,j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i=0 ; i<total ; i++)
        {
            for(int j=0 ; j<total ; j++)
            {
                System.Console.WriteLine($"[{i}] , [{j}] is {array[i,j]}");
            }
        }
    }
}