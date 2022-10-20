using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Number of Terms");
        int term = int.Parse(Console.ReadLine());
        int number1 = 0 , number2 = 1 ,temp , i=0;
        System.Console.WriteLine("Fibonanccii Series For {0} Term is :0 \n1");
        do
        {
            temp = number1 + number2;
            System.Console.WriteLine(temp);
            number1 = number2;
            number2 = temp;
            i++;
        }while(i<term-2);
    }
}