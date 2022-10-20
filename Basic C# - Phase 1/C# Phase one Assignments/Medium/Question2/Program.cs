using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number Of Terms");
        int terms = int.Parse(Console.ReadLine());
        int number1 = 0 ; int number2 = 1 ; int sum=0;
        if(terms == 0)
        {
            System.Console.WriteLine("No Terms To Calculate");
        }
        else if(terms == 1)
        {
            System.Console.WriteLine("Fibonnacci /series is:\n0 ");
        }
        else
        {
            System.Console.WriteLine("Fibonnacci /series is:\n0  \n1");
            for(int i=2 ; i<terms ; i++)
            {
                sum = number1 + number2;
                System.Console.WriteLine(sum);
                int temp = number1;
                number1 = number2;
                number2 = sum;
            }
        }
    }
}