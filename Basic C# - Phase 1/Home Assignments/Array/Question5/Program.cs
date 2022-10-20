using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Total Number of inputs");
        int total = int.Parse(Console.ReadLine());
        int[] array = new int[total];
        int[] array1 = new int[(total/2)+1];
        int[] array2 = new int[(total/2)+1];
        System.Console.WriteLine("Enter the {0} Elements in the Array: ",total);
        for (int i=0 ; i<total ; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int k=0; int j=0 ;
        foreach (int num in array)
        {
            {
                if(num%2 == 0)
                {
                    array1[k] = num;
                    k++;
                }
                else
                {
                    array2[j] = num;
                    j++;
                }
            }
        }
        System.Console.WriteLine("Even Numbers are:");
        for (int i=0 ; i<array1.Length ; i++)
        {
            System.Console.Write("\t"+array1[i]);
        }
        System.Console.WriteLine("Odd Numbers are:");
        for (int i=0 ; i<array2.Length ; i++)
        {
            System.Console.Write("\t"+array2[i]);
        }
    }
}
