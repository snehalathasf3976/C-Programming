using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your Name");
        string name = Console.ReadLine();
        System.Console.WriteLine(" Enter age");
        int age = Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("Enter Mark Of Subject 1");
        int mark1 = Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("Enter Mark Of Subject 2");
        int mark2 = Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("Enter Mark Of Subject 3");
        int mark3 = Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("Enter Grade");
        char grade = Char.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Mobile Number");
        long number = Convert.ToInt64 (Console.ReadLine());
        System.Console.WriteLine("Enter your Mail Id");
        string mail_id = Console.ReadLine();
        System.Console.WriteLine("Enter Your CGPA");
        float cgpa = float.Parse (Console.ReadLine());
        int total = mark1 + mark2 + mark3 ;
        double average = (double)total / 3 ;
        System.Console.WriteLine("Name: " +name);
        System.Console.WriteLine("Age: " +age);
        System.Console.WriteLine("Mobile: " +number);
        System.Console.WriteLine("Mark 1: " +mark1);
        System.Console.WriteLine("Mark 2: " +mark2);
        System.Console.WriteLine("Mark 3: " +mark3);
        System.Console.WriteLine("Total: " +total);
        System.Console.WriteLine("Average: " +average);
        System.Console.WriteLine("Grade: " +grade);
        System.Console.WriteLine("Mail Id: " +mail_id);
        System.Console.WriteLine("CGPA: " +cgpa);
    }
}