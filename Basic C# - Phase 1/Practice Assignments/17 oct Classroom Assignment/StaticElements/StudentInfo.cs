using System;
namespace StaticElements;
public static class StudentInfo
{
    public static int RegistrationNumber;
    public static string Name { get; set; }
    static StudentInfo()
    {
        RegistrationNumber = 1000;
        Name = "Snehalatha" ; 
    }
    public static void Display()
    {
        System.Console.WriteLine("Registration Number is: "+RegistrationNumber);
        System.Console.WriteLine("Name is: "+Name);
    }
}