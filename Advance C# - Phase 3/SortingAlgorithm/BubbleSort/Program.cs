using System;
namespace BubbleSort;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Length of the Array");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        System.Console.WriteLine("Enter the Elements of the Array");
        for(int i=0 ; i<length ; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for(int i=0 ; i<length-1 ; i++)
        {
            for(int j=0 ; j<length-1-i ; j++)
            {
                if(array[j] > array[j+1])
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1]=temp;
                }
            }
        }
        for(int i=0 ; i<length ; i++)
        {
            System.Console.Write(array[i]+"\t");
        }
    }
}