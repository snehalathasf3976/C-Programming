using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Starting Number");
        int startNumber = int.Parse(Console.ReadLine());
        int sum=0 ; int loop=1;
        System.Console.WriteLine("Enter the Difference Number");
        int differenceNumber = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Number Elements");
        int number = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Out Put Series is:");
        while(loop <= number)
        {
            System.Console.WriteLine(startNumber);
            sum = sum + startNumber ;
            startNumber = startNumber+ differenceNumber;
            loop++;
        }
        System.Console.WriteLine("Sum is:"+sum);
    }
}
