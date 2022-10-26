using System;
namespace AbstractClass;
class Program
{
    public static void Main(string[] args)
    {
        Syncfusion job1 = new Syncfusion();
        job1.Name = "Software Engineer";
        job1.Salary(20);

        TCS job2 = new TCS();
        job2.Name = "Testing Engineer";
        job2.Salary(20);
    }
}