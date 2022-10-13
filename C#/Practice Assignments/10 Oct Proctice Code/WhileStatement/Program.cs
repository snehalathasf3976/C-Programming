using System;
namespace WhileStatement
{
   class Program
   {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Do you feel hungry");
        string condition = Console.ReadLine();
        while (condition == "yes")
        {
           System.Console.WriteLine("Eat Food");
           System.Console.WriteLine("Do You feel Hungry");
           condition = Console.ReadLine();
            
        }
    }
   }
}
