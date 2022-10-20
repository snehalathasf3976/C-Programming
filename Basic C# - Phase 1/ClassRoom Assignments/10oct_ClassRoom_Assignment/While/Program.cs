using System;
namespace While;
class Program
{
    public static void Main(string[] args)
    {
        int i=0;
        while (i<=25)
        {
           if(i%2 == 0)
           {
            System.Console.WriteLine(i);
           }
           i++;
        }


        //Excersice 2
        System.Console.WriteLine("Enter the Number");
        bool temp = int.TryParse(Console.ReadLine(), out int number);
        while (temp == false)
        {
            System.Console.WriteLine("Invalid input format. Please enter the input in number format");
            System.Console.WriteLine("Enter the Number");
            temp = int.TryParse(Console.ReadLine(), out number);

        }
        System.Console.WriteLine("The Number is " +number);
    }
}