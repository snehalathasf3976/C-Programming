using System;
namespace InsertionSort;
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
        for(int i=0 ; i<length ; i++)
        {
            for(int j=i ; j<length ; j++)
            {
                if(array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j]=temp;
                }
            }
        }
        for(int i=0 ; i<length ; i++)
        {
            System.Console.Write(array[i]+"\t");
        }
    }
    
}