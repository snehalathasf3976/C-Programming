using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Basic Pay: ");
        int salary = int.Parse(Console.ReadLine());
        int salaryPlus , annualSalary , total ; 
        if (salary <= 10000)
        {
            salaryPlus = (((20/100)*salary)+(80/100)*salary);
            annualSalary = (((6/100)*salary)+(1/100)*salary);
            total = (salary * 12 ) + salaryPlus - annualSalary;
            System.Console.WriteLine("Annual Salary is: "+total);
        }
        else if (salary <= 20000)
        {
            salaryPlus = (((20/100)*salary)+(80/100)*salary);
            annualSalary = (((6/100)*salary)+(1/100)*salary);
            total = (salary * 12 ) + salaryPlus - annualSalary;
            System.Console.WriteLine("Annual Salary is: "+total);
        }
        else
        {
            salaryPlus =(((20/100)*salary)+(80/100)*salary);
            annualSalary = (((6/100)*salary)+(1/100)*salary);
            total = (salary * 12 ) + salaryPlus - annualSalary;
            System.Console.WriteLine("Annual Salary is: "+total);
        }
    }
}