using System;
using System.Collections.Generic;
namespace CollegeAdmission;
public static class Operations
{
    public static List<StudentDetails> studentList = new List<StudentDetails>();
    public static List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
    public static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();

    public static void MainMenu()
    {
        System.Console.WriteLine("This is Main Menu\n");
        string condition = "YES";
        do
        {
            System.Console.WriteLine("Enter the Operation to Do \n1.Registration \n2.Login \n3.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Registration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exiting the Application");
                    condition = "NO";
                    break;
                }
            }
            System.Console.WriteLine("Do you Wanna Continue");
            condition = Console.ReadLine().ToUpper();
        }while(condition == "YES");
    } 
    static void Registration()
    {
        System.Console.WriteLine("\nRegistration Called\n");
        System.Console.WriteLine("Enter Your Name: ");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter Your Father Name: ");
        string fatherName = Console.ReadLine();
        System.Console.WriteLine("Enter Your DOB in dd/mm/yyyy Format");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/mm/yyyy",null);
        System.Console.WriteLine("Enter Your Gender Male , Female , TransGender");
        Gender studentGender = Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter Your Physics Mark");
        int physicsMark = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Your Chemistry Mark");
        int chemistryMark = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Your Maths Mark");
        int mathsMark = int.Parse(Console.ReadLine());
        StudentDetails student = new StudentDetails(name , fatherName , dob , studentGender , physicsMark , chemistryMark , mathsMark);
        System.Console.WriteLine("Registration Successfull!!!\nYour Registration ID is: "+student.StudentId);
        studentList.Add(student);
    }
    static void Login()
    {
        System.Console.WriteLine("\nLogin Called\n");
        System.Console.WriteLine("Enter the Student Id: ");
        string studentId = Console.ReadLine().ToUpper();
        int count = 0 ;
        foreach(StudentDetails student in studentList)
        {
            if(studentId == student.StudentId)
            {
               System.Console.WriteLine("LogIn Successfull");
               SubMenu(student);
               count = 0;
               break;
            }
            else 
            {
                count = 1;
            }
        }
        if(count == 1 )
        {
            System.Console.WriteLine("Invalid User");
        }
    }

    static void SubMenu(StudentDetails student)
    {
        System.Console.WriteLine("\nSub Menu\n");
        string condition = "YES";
        do
        {
            System.Console.WriteLine("Enter the Process to do\n1.Check Eligibility \n2.Show Details\n3.Take Admission \n4.Cancel Admission \n5.Show Admission Details \n6.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    System.Console.WriteLine("Check Eligibility");
                    bool temp = student.CheckEligibility(75.0);
                    if(temp)
                    {
                        System.Console.WriteLine("Student is Eligible");
                    }
                    else
                    {
                        System.Console.WriteLine("Student is Not Eligible");
                    }
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Show Details");
                    ShowDetails(student);
                    break;
                }
                case 3:
                {
                    TakeAdmission(student);
                    break;
                }
                case 4:
                {
                    CancelAdmission(student);
                    break;
                }
                case 5:
                {
                    ShowAdmissionDetails(student);
                    break;
                }
                case 6:
                {
                    condition = "no";
                    break;
                }
            }
        }while(condition == "YES");


    }
    static void ShowDetails(StudentDetails details)
    {
        System.Console.WriteLine("Show Details Called");
        System.Console.WriteLine("|Student Id |   Student Name   |   Father Name   | Date Of Birth | Gender | Physics | Chemistry | Maths |");
        System.Console.WriteLine("|-------------------------------------------------------------------------------------------------------|");
        System.Console.WriteLine($"| {details.StudentId,-9} | {details.StudentName,-16} | {details.FatherName,-15} | {details.DOB.ToString("dd/MM/yyyy"),-13} | {details.StudentGender, -6} | {details.PhysicsMark, -7} | {details.ChemistryMark,-9} | {details.MathsMark,-5} |");  
        System.Console.WriteLine("|-------------------------------------------------------------------------------------------------------|"); 

    }
    static void TakeAdmission(StudentDetails student)
    {
        System.Console.WriteLine("Take Admission Called");

        System.Console.WriteLine("|Department Id | Department Name |Number Of Seats |");
        foreach(DepartmentDetails details in departmentList)
        {
          System.Console.WriteLine($"| {details.DepartmentId,-12} | {details.DepartmentName,-15} | {details.NumberOfSeats,-14} |");  
        }
        System.Console.WriteLine("Enter the Department Id in Which You Have to Take Admission");
        string departmentId = Console.ReadLine().ToUpper();
        int temp = 0;
        foreach(DepartmentDetails department in departmentList)
        {
            if(departmentId == department.DepartmentId)
            {
                System.Console.WriteLine("Department Available in the List");
                bool check = student.CheckEligibility(75.0);
                if(check)
                {
                    System.Console.WriteLine("Student is Eligible");
                    if(department.NumberOfSeats > 0)
                    {
                        System.Console.WriteLine("Seat Available");
                        bool flag = true ;
                        foreach(AdmissionDetails admission in admissionList)
                        {
                            if(student.StudentId == admission.StudentId && admission.AdmissionStatus == AdmissionStatus.Booked)
                            {
                                flag = false ;
                                System.Console.WriteLine("You Have Already Taken Admission");
                            }
                          
                        }

                         if(flag)
                            {
                                department.NumberOfSeats--;
                                AdmissionDetails studentAdmission = new AdmissionDetails(student.StudentId , department.DepartmentId , DateTime.Now , AdmissionStatus.Booked );
                                admissionList.Add(studentAdmission);
                                System.Console.WriteLine("Admission Taken Successfully , Your Registration Id is: "+studentAdmission.AdmissionId);
                            }
                    }
                    else 
                    {
                        System.Console.WriteLine("Seat Not Available");
                    }
                }
                else
                {
                    System.Console.WriteLine("Student Not Eligible");
                }
                temp = 0;
                break;
            }
            else
            {
                temp = 1;
            }
        }
        if(temp == 1)
        {
            System.Console.WriteLine("Department Id Not Present in the Given List");
        }

    }
    static void CancelAdmission(StudentDetails student)
    {
        System.Console.WriteLine("Cancel Admission Cancelled");
        int count = 0;
        foreach(AdmissionDetails admission in admissionList)
        {
            if(student.StudentId == admission.StudentId && admission.AdmissionStatus == AdmissionStatus.Booked)
            {
                admission.AdmissionStatus = AdmissionStatus.Cancelled;
                foreach(DepartmentDetails department in departmentList)
                {
                    if(admission.DepartmentId == department.DepartmentId)
                    {
                        department.NumberOfSeats++;
                        count = 1;
                    }
                }
                System.Console.WriteLine("Seat Calcelled Successfully");
            }
        }
        if(count == 0)
        {
            System.Console.WriteLine("You Have Not Taken Any Admission");
        }
    }
    static void ShowAdmissionDetails(StudentDetails student)
    {
        System.Console.WriteLine("Show Details Called");
        int temp = 0  ;
        foreach(AdmissionDetails admission in admissionList)
        {
            if(admission.StudentId == student.StudentId)
            {
                System.Console.WriteLine("Admission ID is: "+admission.AdmissionId);
                System.Console.WriteLine("Admission Department Id is: "+admission.DepartmentId);
                System.Console.WriteLine("Admission Date is: "+admission.AdmissionDate);
                System.Console.WriteLine("Admission Status is: "+admission.AdmissionStatus);
                temp = 1;
            }
        }
        if(temp != 1 )
        {
            System.Console.WriteLine("Student Doesn't take Admission in the College till Now");
        }
    }
    public static void DefaultDetails()
    {
        StudentDetails student = new StudentDetails("Ravichanran E" , "Ettaparajan" , new DateTime(1999 ,11 ,11) , Gender.Male , 95 , 95 , 95) ;
        studentList.Add(student);
        StudentDetails student1 = new StudentDetails("Baskaran S" , "Sethurajan" , new DateTime(1999 ,11 ,11) , Gender.Male , 95 , 95 , 95) ;   
        studentList.Add(student1);

        DepartmentDetails department = new DepartmentDetails("EEE" , 29); 
        departmentList.Add(department);
        DepartmentDetails department1 = new DepartmentDetails("CSE" , 29); 
        departmentList.Add(department1);
        DepartmentDetails department2 = new DepartmentDetails("MECH" , 30); 
        departmentList.Add(department2);
        DepartmentDetails department3 = new DepartmentDetails("ECE" , 30);
        departmentList.Add(department3); 

        AdmissionDetails admission = new AdmissionDetails(student.StudentId , department.DepartmentId , new DateTime (2022 , 05 , 11) , AdmissionStatus.Booked);
        admissionList.Add(admission);
        AdmissionDetails admission1 = new AdmissionDetails(student1.StudentId , department.DepartmentId , new DateTime (2022 , 05 , 11) , AdmissionStatus.Booked);
        admissionList.Add(admission1);
    }
   
}