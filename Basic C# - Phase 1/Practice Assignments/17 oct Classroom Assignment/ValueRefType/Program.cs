using System;
namespace ValueRefType; 
class Program 
{
    public static void Main(string[] args)
    {
        int number1 = 10;
        int number2 = number1 ; 
        System.Console.WriteLine("Number 1 is: "+number1+" Number 2 is: "+number2);
        number2 = 40;
        System.Console.WriteLine("Number 1 is: "+number1+" Number 2 is: "+number2);


        //class
        Reference object1;
        object1 = new Reference();
        object1.Number1 = 10;
        Reference object2 = object1 ;
        System.Console.WriteLine("Number 1 is: "+object1.Number1+" Number 2 is: "+object2.Number1);
        object2.Number1 = 40;
        System.Console.WriteLine("Number 1 is: "+object1.Number1+" Number 2 is: "+object2.Number1);
    }
}