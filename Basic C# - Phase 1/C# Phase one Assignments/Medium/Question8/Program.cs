using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the String");
        string string1 = Console.ReadLine();
        string check = "";
        
        foreach(char value in string1)
        {
            if(value >='0' && value <= '9')
            {
                check = check + value;
            }
        }
        int number = int.Parse(check);
        System.Console.WriteLine("Number is: "+number);
        if(number % 2 ==0)
        {
            System.Console.WriteLine("Even Number");
        }
        else
        {
            System.Console.WriteLine("Odd Number");
        }
    }
}