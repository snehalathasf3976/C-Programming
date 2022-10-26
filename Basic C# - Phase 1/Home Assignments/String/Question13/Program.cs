using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Main String: ");
        string string1 = Console.ReadLine();
        string result = "0"; int number = 0;
        for (int i=0 ;  i<string1.Length ;i++)
        {
            if(string1[i] >= '0' && string1[i] <= '9')
            {
                result = result + string1[i];
            }
        }
        number = int.Parse(result);
        int sum = 0;
        for(int i=0 ; i<result.Length - 1 ; i++ )
        {
            int digit = number % 10;
            sum = sum + digit;
            number = number / 10;
        }
        System.Console.WriteLine("sum is: "+sum);
    }
}