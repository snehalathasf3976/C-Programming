using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Total Number of inputs");
        int total = int.Parse(Console.ReadLine());
        int[] array = new int[total];
        System.Console.WriteLine("Enter the {0} Elements in the Array: ",total);
        for (int i=0 ; i<total ; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int max=array[0] ;int min=array[0];
        for (int i=0 ; i<total ; i++)
        {
            if(array[i] > max)
            {
                max = array[i];
            }
            if(array[i] < min)
            {
                min = array[i];
            }
        }
        System.Console.WriteLine("The Maximum is: "+max);
        System.Console.WriteLine("The Maximum is: "+min);
    }
}