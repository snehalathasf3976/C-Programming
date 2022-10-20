using System;
namespace ArithmeticOperator;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the First Number");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the 2nd Number");
        int number2=int.Parse(Console.ReadLine());
        System.Console.WriteLine(number1+ "+" +number2+ "=" +(number1+number2) );
        System.Console.WriteLine(number1+ "-" +number2+ "=" +(number1-number2));
        System.Console.WriteLine(number1+ "*" +number2+ "=" +(number1*number2));
        System.Console.WriteLine(number1+ "/" +number2+ "=" +(number1/number2));
        System.Console.WriteLine(number1+ "%" +number2+ "=" +(number1%number2));
    }
}