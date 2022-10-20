using System;
using System.Collections.Generic;
namespace BankApplication;
public class BankMainMenu
{
    static List<BankDetails> customerList = new List<BankDetails>();
    public static void MainMenu()
        {
            string condition = "YES";
            do
            {
                System.Console.WriteLine("Enter the Operation to do \n !.Registarion \n2.Login \n3..Exit");
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
                        Login(condition);
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
        {
            System.Console.WriteLine("Enter the name");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter Father Name");
            string fatherName= Console.ReadLine();

            System.Console.WriteLine("Select the Gender: Male , Female, Transgender");
            Gender gender= Enum.Parse<Gender>(Console.ReadLine(),true);

            System.Console.WriteLine("Select the Accout Type: RD , SA , FD");
            AccountType accountType = Enum.Parse<AccountType>(Console.ReadLine(),true);

            BankDetails customer = new BankDetails(name , fatherName , gender , accountType);
            System.Console.WriteLine("Your Registration Id is: "+customer.CustomerId);
            customerList.Add(customer);
        }
    }
    public static void Login(string condition)
    {
        System.Console.WriteLine("Enter the Customer Id");
        string customerId = Console.ReadLine();
        foreach(BankDetails customer in customerList)
        {
            if(customer.CustomerId == customerId)
            {
            condition = "YES";
            do
            {
                System.Console.WriteLine("Enter the Operation to do \n1.Deposit \n2.Withdraw \n3.Show Balance \n4.Exit");
                int choice = int.Parse(Console.ReadLine());
                int balance;
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Enter the Deposit Amount");
                        int depositAmount = int.Parse(Console.ReadLine());
                        balance = customer.Deposit(depositAmount);
                        System.Console.WriteLine("Your Balance is: "+balance);
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Enter the Deposit Amount");
                        int withdrawAmount = int.Parse(Console.ReadLine());
                        balance = customer.Withdraw(withdrawAmount);
                        if(balance == 0)
                        {
                            System.Console.WriteLine("Insufficient Balace");
                        }
                        else
                        {
                            System.Console.WriteLine("Balnce is: "+balance);
                        }
                        break;
                    }
                    case 3:
                    {
                        balance = customer.ShowBalance();
                        System.Console.WriteLine("Balance is: "+balance);
                        break;
                    }

                    case 4:
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
        }
        foreach(BankDetails customer in customerList)
        {
            if(customer.CustomerId != customerId)
            {
                System.Console.WriteLine("Invalid User");
            }
        }
    }

}