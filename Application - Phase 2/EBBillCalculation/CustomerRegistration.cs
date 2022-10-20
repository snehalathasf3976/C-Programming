using System;
using System.Collections.Generic;
namespace EBBillCalculation;
public class CustomerRegistration
{
    static List<CustomerDetails> customerList = new List<CustomerDetails>();
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

        System.Console.WriteLine("Enter The Mobile Number : ");
        long mobileNumber = long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Mail ID");
        string mailId = Console.ReadLine();

        CustomerDetails customer = new CustomerDetails(name , mobileNumber , mailId);
        System.Console.WriteLine("Your Meter Id is: "+customer.MeterId);
        customerList.Add(customer);
    }
    public static void Login()
    {
        System.Console.WriteLine("Enter the Meter Id");
        string meterId = Console.ReadLine();
        foreach(CustomerDetails customer in customerList)
        {
            if(customer.MeterId == meterId)
            {
                string condition = "YES";
                do
                {
                    System.Console.WriteLine("Enter the Operation to do \n1.Calculate Amount \n2.Display Details \n3.Exit");
                    int choice = int.Parse(Console.ReadLine());
                    int amount ;
                    switch(choice)
                    {
                        case 1:
                        {
                            System.Console.WriteLine("Enter the Unit");
                            int unit = int.Parse(Console.ReadLine());
                            amount = customer.CalculateBill(unit);
                            System.Console.WriteLine("Your bill is: "+amount);
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
                System.Console.WriteLine("Name is: "+customer.CustomerName);
                System.Console.WriteLine("Meter ID is: "+customer.MeterId);
                System.Console.WriteLine("Mobile Number: "+customer.MobileNumber);
                System.Console.WriteLine("EMAil Id: "+customer.MailId);
            }
        }
    }


}