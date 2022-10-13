using System;
namespace DoWhile ;
class Program
{
    public static void Main(string[] args)
    {
        string condition="";
        do
        {
            System.Console.WriteLine("Eat Food");
            System.Console.WriteLine("Do You feel Hungry");
            condition = Console.ReadLine();
        }while(condition == "yes");
    }
}