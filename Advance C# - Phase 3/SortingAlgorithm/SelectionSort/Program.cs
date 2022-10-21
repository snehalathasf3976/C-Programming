using System;
namespace SelectionSort;
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
            int minValue = array[i];
            int minIndex = i;
            for(int j=i ; j<length ; j++)
            {
                if(array[j] < minValue)
                {
                    minValue = array[j];
                    minIndex = j ;
                }
            }
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex]=temp;
        }
        for(int i=0 ; i<length ; i++)
        {
            System.Console.Write(array[i]+"\t");
        }
    }
}