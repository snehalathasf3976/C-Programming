using System;
using System.Collections.Generic;
namespace PayRollManagement;

public class EmployeeRegistration
{
    static List<PayRollDetails> payList = new List<PayRollDetails>();
    public static void MainMenu()
    {
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
                    System.Console.WriteLine("Do You Wanna Continue");
                    condition = Console.ReadLine().ToUpper();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    condition = "no";
                    break;
                }
                
            } 
        }while(condition == "YES");
    }
    public static void Registration()
    {

        System.Console.WriteLine("Enter the Name");
        string name = Console.ReadLine();

        System.Console.WriteLine("Enter Your Work Role");
        string employeeRole = Console.ReadLine();
        
        System.Console.WriteLine("Enter Your Work Location");
        string employeeWorkLocation = Console.ReadLine();

        System.Console.WriteLine("Enter Date of Joining in dd/mm/yyyy Format");
        DateTime dateOfJoining =DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);

        System.Console.WriteLine("Enter The Number of Worked Days in a Month: ");
        int numberOfWorkedDays = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter The Number of Leave Taken in a Month: ");
        int numberOfLeaveTaken = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Select the Gender: Male , Female , Transgender");
        Gender gender =Enum.Parse<Gender>(Console.ReadLine(),true);

        PayRollDetails pay = new PayRollDetails(name , employeeRole , employeeWorkLocation ,dateOfJoining  , numberOfWorkedDays , numberOfLeaveTaken , gender );
        System.Console.WriteLine("Your Employee Id is: "+pay.EmployeeId);
        payList.Add(pay);
    }
    public static void Login()
    {
        System.Console.WriteLine("Enter the Employee Id");
        string employeeId = Console.ReadLine();
        foreach(PayRollDetails employee in payList)
        {
            if(employee.EmployeeId == employeeId)
            {
                string condition = "YES";
                do
                {
                    System.Console.WriteLine("Enter the Operation to do \n1.Calculate Salary \n2.Display Details \n3.Exit");
                    int choice = int.Parse(Console.ReadLine());
                    int salary ;
                    switch(choice)
                    {
                        case 1:
                        {
                            salary = employee.CalculateSalary(employee.NumberOfWorkedDays);
                            System.Console.WriteLine("Your Salary is: "+salary);
                            break;
                        }
                        case 2:
                        {
                            DisplayDetails();
                            break;
                        }
                        case 3:
                        {
                            condition = "no";
                            break;
                        }
                    }
                    if(condition == "YES")
                    {
                        System.Console.WriteLine("Do You Wanna Continue");
                        condition = Console.ReadLine().ToUpper();
                    }
                }while(condition == "YES");
            }
            void DisplayDetails()
            {
                System.Console.WriteLine("Name is: "+employee.EmployeeName);
                System.Console.WriteLine("Employee Role is: "+employee.EmployeeRole);
                System.Console.WriteLine("Employee Work Location  is: "+employee.EmployeeWorkLocation);
                System.Console.WriteLine("Employee Date Of Joining is: "+employee.DateOfJoining);
                System.Console.WriteLine("Gender is: "+employee.EmployeeGender);
                System.Console.WriteLine("Number of Worked Days is: "+employee.NumberOfWorkedDays);
                System.Console.WriteLine("Number of Leave taken is: "+employee.NumberOfLeaveTaken);
            }

        }
    }
}