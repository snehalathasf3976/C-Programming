using System;
namespace Interfaces ;
class Program
{
    public static void Main(string[] args)
    {
        Square square = new Square();
        square.Number=20;
        System.Console.WriteLine("Square is: "+square.Calculate());

        ICalculate number = new Square();
        number.Number =10;
        System.Console.WriteLine(number.Calculate());
    }
}