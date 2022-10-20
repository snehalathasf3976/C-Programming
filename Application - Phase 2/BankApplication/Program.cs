using System;
using System.Collections.Generic;
namespace BankApplication;
class Program
{
    public static void Main(string[] args)
    {
        BankMainMenu.MainMenu();
            


        /*foreach (BankDetails display in userList)
        {
            System.Console.WriteLine("Name is:"+display.Name);
            System.Console.WriteLine("Father Name is: "+display.FatherName);
            System.Console.WriteLine("Gender is: "+display .Gender);
            System.Console.WriteLine("AccountType is: "+display .AccountType);

            System.Console.WriteLine("Enter the Amount to be Deposited");
            int depositAmount = int.Parse(Console.ReadLine());
            display.Deposit(depositAmount);
            System.Console.WriteLine("Balance is: "+display.ShowBalance()); 

            System.Console.WriteLine("Enter the Amount To be Withdraw");
            int withdrawAmount = int.Parse(Console.ReadLine());
            int temp = display.Withdraw(withdrawAmount);
            if(temp == 0)
            {
                System.Console.WriteLine("Insufficient Value");
            }
            else
            {
                System.Console.WriteLine("Balance is: "+display.Balance);
            }           
        }*/
    }
}
