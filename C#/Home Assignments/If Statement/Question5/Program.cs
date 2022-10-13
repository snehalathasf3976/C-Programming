using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Physics Mark: ");
        int mark1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Chemistry Mark: ");
        int mark2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Maths Mark: ");
        int mark3 = int.Parse(Console.ReadLine());
        int total = mark1 + mark2 + mark3 ;
        float percentage = (float) (total/3);
        if (percentage >= 75)
        {
            System.Console.WriteLine("The Candidate is Eligible for Admission");
        }
        else
        {
            System.Console.WriteLine("The Candidate is Not Eligible for Admission");
        }
    }
}