﻿using System;
namespace SingleInheritance;
class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails details = new PersonalDetails("Sneha" , "Venkat" , Gender.Female , "9789871511");
        details.ShowDetails();
        StudentDetails student = new StudentDetails("AID1001" , "Sneha" , "Venkat" , Gender.Female , "9789871511" , Department.CSE , "2022");
        student.ShowStudent();
        
    }
}