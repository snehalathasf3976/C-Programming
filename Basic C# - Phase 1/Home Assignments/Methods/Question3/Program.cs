using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number");
        int number1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Another Number");
        int number2 = int.Parse(Console.ReadLine()); 
        System.Console.WriteLine("Before Swapping Numbers Are: {0} and {1} ",number1,number2);
        Swap(number1 ,number2);
        void Swap(int number1,int number2)
        {
            int temp = number1;
            number1 = number2 ;
            number2 = temp;
            System.Console.WriteLine("After Swapping Numbers Are: {0} and {1} ",number1,number2);
        }
    }
}