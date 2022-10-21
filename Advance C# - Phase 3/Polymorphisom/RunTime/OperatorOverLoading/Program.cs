using System;
namespace OperatorOverLoading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1 = new Box(1.3 , 2.4 , 8.3);
        Box box2 = new Box(1.1 , 1.1 , 1.1);
        Box box3 = box1 + box2;
        Box box4 = new Box();
        box4 = box4.Add(box1 , box2);


        System.Console.WriteLine("Volume of Box one is: "+box1.CalculateVolume());

        System.Console.WriteLine("Volume of Box two is: "+box2.CalculateVolume());
        System.Console.WriteLine("Volume of Concatenated Box is: "+box3.CalculateVolume());
        System.Console.WriteLine("Volume of Method Used Box is: "+box4.CalculateVolume());
    }
}