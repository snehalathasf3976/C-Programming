using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        double basicPay = 10000 ; 
        basicPay = basicPay + (0.1) + (0.1);
        double withoutTaxAnnualSalary = 12 * basicPay;
        double annualSalary = withoutTaxAnnualSalary - ((5/withoutTaxAnnualSalary)*100);
        System.Console.WriteLine("His Annual Salary is: "+annualSalary);
    }
}