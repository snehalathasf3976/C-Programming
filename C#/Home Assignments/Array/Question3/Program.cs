using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Total Number of inputs");
        int total = int.Parse(Console.ReadLine());
        int[] array = new int[total];
        int sum=0;
        System.Console.WriteLine("Enter the {0} Elements in the Array: ",total);
        for (int i=0 ; i<total ; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            sum = sum + array[i];
        }
        System.Console.WriteLine("Sum of Elements in the Array is: "+sum);
    }
}