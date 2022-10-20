using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Total Number of inputs");
        int total = int.Parse(Console.ReadLine());
        int[] array = new int[total];
        int temp =0;
        System.Console.WriteLine("Enter the {0} Elements in the Array: ",total);
        for (int i=0 ; i<total ; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i=0 ; i<total ; i++)
        {
            for (int j=0 ; j<total-1 ; j++)
            {
                if(array[j] > array[j+1])
                {
                    temp = array[j] ;
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
        System.Console.WriteLine("Sorted Array is: ");
        for (int i=0 ; i<total ; i++)
        {
        System.Console.WriteLine(array[i]);
        }
    }
}