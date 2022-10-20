using System;
using System.Collections.Generic;
namespace StudentAdmission;

public static class Operations
{
    static List<StudentDetails> studentList =  new List<StudentDetails>();
    public static void MainMenu()
    {
        string condition = "Yes";
    do
    {
        System.Console.WriteLine("Registration");
        System.Console.WriteLine("-----------------");

        System.Console.WriteLine("Enter the name");
        string studentName = Console.ReadLine();

        System.Console.WriteLine("Enter Father Name");
        string fatherName= Console.ReadLine();

        System.Console.WriteLine("Select Your Gender: Male, Female, Transgender");
        Gender gender= Enum.Parse<Gender>(Console.ReadLine(),true);

        System.Console.WriteLine("Enter the Date of Birth in dd/mm/yyyy Format");
        DateTime dateOfBirth =DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter the Mail Id");
        string mailId = Console.ReadLine();

        System.Console.WriteLine("Enter the Physics Mark");
        int physicsMark = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Chemistry Mark");
        int chemistryMark = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Maths Mark");
        int mathsMark = int.Parse(Console.ReadLine());

        StudentDetails student1=new StudentDetails(studentName , fatherName , gender , dateOfBirth  , mailId ,physicsMark , chemistryMark , mathsMark );
        System.Console.WriteLine("Your Registration Id is: " +student1.RegistrationId);
        studentList.Add(student1);

        System.Console.WriteLine("Do you Wanna Continue");
        condition = Console.ReadLine();
        
    }while(condition == "Yes");

        System.Console.WriteLine("Enter the Registration Number");
        string registrationId = Console.ReadLine();

        foreach(StudentDetails student in studentList)
        {
            if(student.RegistrationId == registrationId)
            {
                System.Console.WriteLine("User Found");
                ShowDetails(student);
                bool eligible = student.CheckEligibility(75.0);
                if(eligible)
                {
                    System.Console.WriteLine("Student is Eligible For Admission");
                }
                else
                {
                    System.Console.WriteLine("Student is Not Eligible For Admission");
                }
            }
        }
        void ShowDetails(StudentDetails student)
        {
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("|RegistrationId| Student Name | Father Name | Gender | Date Of Birth |  Maid Id | PhysicsMark | ChemistryMark | MathematicsMark" );
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("|   "+student.RegistrationId+"     |  " +student.StudentName+" |   " +student.FatherName+ " | "+student.StudentGender+" | " +student.DOB.ToString("dd/MM/yyyy")+ " | " +student.MailId+ " |     "+student.PhysicsMark+"     |    "+student.ChemistryMark+"  |    " +student.MathsMark+ " | ");
            System.Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
        }
    
    }

    public static void Login()
    {
        System.Console.WriteLine("IM in Login");
    }
}
