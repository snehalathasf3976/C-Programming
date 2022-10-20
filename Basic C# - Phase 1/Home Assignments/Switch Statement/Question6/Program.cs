using System;
namespace Question6;
class Prigram
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Radius");
        int radius = int.Parse(Console.ReadLine());
        System.Console.WriteLine("1.Area \n2.Perimeteer \n3.Diameter \nChose the Option to Perform the Operation");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            {
                System.Console.WriteLine("Area of the Circle is "+(3.14 * radius * radius));
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Area of the Circle is "+(3.14 * 2 * radius));
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Area of the Circle is "+(3.14  * radius));
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid Option");
            }
                break;
        }
        
    }
}