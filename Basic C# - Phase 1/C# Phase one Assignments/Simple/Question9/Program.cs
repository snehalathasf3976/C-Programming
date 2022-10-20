using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        int salary=1;
        System.Console.WriteLine("Enter the name of Month");
        string month=Console.ReadLine().ToUpper();
        System.Console.WriteLine("Number of Leaves Taken: ");
        int leave = int.Parse(Console.ReadLine());
        switch(month)
        {
            case "JANUARY":
            {
                salary = 500 * 31;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "FEBURARY":
            {
                salary = 500 * 28;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "MARCH":
            {
                salary = 500 * 31;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "APRIL":
            {
                salary = 500 * 30;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "MAY":
            {
                salary = 500 * 31;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "JUNE":
            {
                salary = 500 * 30;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "JULY":
            {
                salary = 500 * 31;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "AUGUST":
            {
                salary = 500 * 31;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "SEPTEMBER":
            {
                salary = 500 * 30;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "OCTOBER":
            {
                salary = 500 * 31;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "NOVEMBER":
            {
                salary = 500 * 30;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            case "DECEMBER":
            {
                salary = 500 * 31;
                System.Console.WriteLine("Salary is: "+salary);
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid");
                break;
            }
        }
        
    }
}