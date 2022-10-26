using System;
namespace MultiLevelInheritance;
public class EmploymentDetails:StudentDetails
{
    static int s_employmentId = 1000;
    public string EmploymentId { get; set; }
    public DateTime RegistrationDate { get; set; }

    public EmploymentDetails(string StudentID , string aid , string name , string fatherName , Gender gender , string mobileNumber , Department department ,  DateTime registrationDate ): base( aid , name , fatherName , gender , mobileNumber , department , StudentID )
    {
        s_employmentId++;
        EmploymentId = "EID" + s_employmentId;
        RegistrationDate = registrationDate ;
    }
    public void ShowEmployment()
    {
        System.Console.WriteLine("Employment Id is: "+EmploymentId);
        System.Console.WriteLine("Student Id is: "+StudentId);
        ShowDetails();
        System.Console.WriteLine("Department Id is: "+Department);
        System.Console.WriteLine("Registration Date is: "+RegistrationDate);
    }
}