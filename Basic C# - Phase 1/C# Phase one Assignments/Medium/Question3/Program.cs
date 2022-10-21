using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Current Date in dd/MM/yyyy ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy" , null);
            DateTime checkDate = DateTime.Now;
            //System.Console.WriteLine(checkDate.ToShortDateString);
            if(date.Day == checkDate.Day && date.Month == checkDate.Month && date.Year == checkDate.Year)
            {
                System.Console.WriteLine("Its Current Date Format");
            }
            else
            {
                System.Console.WriteLine("Its Not Current Date Format");
            }
        }
    }
}