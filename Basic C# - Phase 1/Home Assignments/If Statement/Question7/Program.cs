using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Customer ID");
        int id = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Name");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter the Units Consumed");
        int unit = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Customer IDNO: "+id);
        System.Console.WriteLine("Customer Name: "+name);
        System.Console.WriteLine("Units Consumed: "+unit);
        double amount;
        if(unit <= 199)
        {
            amount = (double) unit * 1.20;
            if (amount < 100)
            {
                System.Console.WriteLine("Net Amount Paid By the Customer: 100");
            }
            else
            {
                System.Console.WriteLine("Net Amount Paid By the Customer: "+amount);
            }
        }
        else if (unit >= 200 && unit < 400)
        {
            amount = (double) unit * 1.50 ;
            System.Console.WriteLine("Net Amount Paid By the Customer: "+amount);
        }
        else if (unit >= 400 && unit < 600)
        {
            amount = (double) unit * 1.80;
            System.Console.WriteLine("Amount Charged @1.80 Per Unit is: "+amount);
            double surchageAmount = (amount)*15/100;
            System.Console.WriteLine("Surcharged Amount: "+surchageAmount);
            System.Console.WriteLine("Net Amount Paid By the Customer: "+(surchageAmount + amount));
        }
        else
        {
            amount = (double) unit * 2.00;
            System.Console.WriteLine("Amount Charged @1.80 Per Unit is: "+amount);
            double surchageAmount = (amount)*15/100;
            System.Console.WriteLine("Surcharged Amount: "+surchageAmount);
            System.Console.WriteLine("Net Amount Paid By the Customer: "+(amount + surchageAmount));
        }
    }
}