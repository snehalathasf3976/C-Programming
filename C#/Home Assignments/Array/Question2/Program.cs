using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Total Number of inputs");
        int total = int.Parse(Console.ReadLine());
        int[] array = new int[total];
        System.Console.WriteLine("Enter the {0} Elements into the Array",total);
        for (int i=0 ; i<total ; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Elements in the Array is: ");
        for (int i=0 ; i<total ; i++)
        {
            System.Console.Write("\t"+array[i]);
        }
        System.Console.WriteLine("\nElements in the Array in Reverse Order is: ");
        for (int i=total-1 ; i>=0 ; i--)
        {
            System.Console.Write("\t"+array[i]);
        }
    }
}