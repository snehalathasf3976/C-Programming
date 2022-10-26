using System;
using Outside;
namespace Inside;
class Program
{
    public static void Main(string[] args)
    {
        First one = new First();
        System.Console.WriteLine(one.Number1);

        //System.Console.WriteLine(one.Number2);
        System.Console.WriteLine(one.OutNumber2);

        //System.Console.WriteLine(one.Number3);
        Second two = new Second();
        System.Console.WriteLine(two.OutNumber3);

        System.Console.WriteLine(two.Number4);

        System.Console.WriteLine(one.OutNumber5);
    }
}