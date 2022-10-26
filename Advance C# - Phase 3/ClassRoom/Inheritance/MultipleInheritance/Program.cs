using System;
namespace MultipleInheritance;
class Program
{
    public static void Main(string[] args)
    {
        //PersonalDetails details = new PersonalDetails("Sneha" , "Venkat" , Gender.Female , "9789871511");
        //details.ShowDetails();

        StudentDetails student = new StudentDetails("AID1001" , "Sneha" , "Venkat" , Gender.Female , "9789871511" , Department.CSE , "2022");
        student.ShowStudent();
        student.GetMark(78 , 90 , 60);
        student.Calculate();
        student.ShowMark();
        
        //CustomerDetails customer = new CustomerDetails("AID1001" , "Sneha" , "Venkat" , Gender.Female , "9789871511" , 3000);
        //customer.Show();

        //EmploymentDetails employee = new EmploymentDetails("SID1001" , "AID1001" , "Sneha" , "Venkat" , Gender.Female , "9789871511" , Department.CSE ,new DateTime(2022,10,11) );
        //employee.ShowEmployment();
    }
}