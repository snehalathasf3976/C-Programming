using System;
namespace LinearSearch;
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
        int check = 0;
        for(int i=0 ; i<length ; i++)
        {
            if(array[i] == searchElement)
            {
                System.Console.WriteLine("Element Found and it is at "+i+" Position");
                check = 1;
                break;
            }
        }
        if(check == 0)
        {
            System.Console.WriteLine("Element Not Found");
        }
    }
}