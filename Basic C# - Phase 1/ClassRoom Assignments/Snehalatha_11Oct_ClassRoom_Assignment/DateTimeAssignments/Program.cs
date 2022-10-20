using System;
namespace DateTimeAssignment;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine("Year is: "+date.Year);
        System.Console.WriteLine("Month is: "+date.Month);
        System.Console.WriteLine("Day is: "+date.Day);
        System.Console.WriteLine("Hour is: "+date.Hour);
        System.Console.WriteLine("Minutes is: "+date.Minute);
        System.Console.WriteLine("Seconds is: "+date.Second);
        string sdate = date.ToString("yyyy/MM/dd hh:mm:ss tt");
        System.Console.WriteLine(sdate);
        char[] separators = new char[] { ':', '/' , ' '};
        string[] subs = sdate.Split(separators, StringSplitOptions.None);
        for (int i=subs.Length-1 ; i>=0 ; i--)
        {
            System.Console.Write(subs[i]+"\t");
        }
        System.Console.WriteLine("Enter Date Time in yyyy/MM/dd  hh:mm:ss  tt Format");
        DateTime user = DateTime.ParseExact(Console.ReadLine() , "yyyy/MM/dd hh:mm:ss tt",null);
        System.Console.WriteLine("Year Month Day is: "+user.ToString("yyyy/MM/dd"));
    }
}