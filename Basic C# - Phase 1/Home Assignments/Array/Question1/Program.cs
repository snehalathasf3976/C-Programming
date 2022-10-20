using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Total Number of inputs");
        int total = int.Parse(Console.ReadLine());
        int[] array = new int[total];
        System.Console.WriteLine("Enter the Elements");
        for (int i=0 ; i<total ; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Elements in the Array is: ");
        for (int i=0 ; i<total ; i++)
        {
            System.Console.WriteLine(array[i]);
        }
    }
}