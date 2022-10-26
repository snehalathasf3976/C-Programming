using System;
namespace BinarySearch;
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
        System.Console.WriteLine("Enter the Elements to Search in the Array: ");
        int searchElement = int.Parse(Console.ReadLine());
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
            System.Console.WriteLine(array[i]);
        }
        BinarySearch(0 , length , searchElement);

        void BinarySearch(int startValue , int endValue , int searchElement)
        {
            int start = startValue;
            int end = endValue ;
            int search = searchElement;
            int middle = (start + end)/2;
            if(middle == 0)
            {
                System.Console.WriteLine("Element Not in Array");
            }
            else if(search == array[middle] )
            {
                System.Console.WriteLine("Elements Found!!!! Its in "+middle+" Position");
            }
            else if(search < array[middle])
            {
                BinarySearch(start , middle-1 , search);
            }
            else
            {
                BinarySearch(middle+1 , end , search);
            }

        }
    }
    
}