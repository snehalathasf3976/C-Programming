using System;
using System.Collections.Generic;
namespace CollegeAdmission;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        //Operations.DefaultDetails();
        Operations.MainMenu();
        Files.WriteToFile();
    }
}