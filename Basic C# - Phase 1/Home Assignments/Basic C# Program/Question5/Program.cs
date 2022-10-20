using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Physics Mark");
        int physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Chemistry Mark");
        int chemistry=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Maths Mark");
        int maths=int.Parse(Console.ReadLine());
        int sum=physics + chemistry + maths ;
        double percentage = (double)((sum*100)/300);
        System.Console.WriteLine("Sum: "+sum);
        System.Console.WriteLine("Percentage: {0}%",Math.Round(percentage));
    }
}
