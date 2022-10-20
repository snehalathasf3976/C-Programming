using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace DateTime1
{
     class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            Console.WriteLine(date.ToString());

            //Create Date time object
            DateTime dob = new DateTime(2022,3,7,16,48,30);
            
                                    //Year,month,day, hour, minute, second -  24 Hour format input
           // Print date time in 24 hour format
            Console.WriteLine(dob.ToString("dd/MM/yyyy HH:mm:ss"));
            // Print date time in 12 hour format
            Console.WriteLine(dob.ToString("dd/MM/yyyy hh:mm:ss tt"));
            // To print time only
            Console.WriteLine(dob.ToString("hh:mm:ss tt"));
            // To Print Date only
            Console.WriteLine(dob.ToString("dd/MM/yyyy"));
            // To print long and short date format
            Console.WriteLine(dob.ToShortDateString());     //MM/dd/yyyy       
            Console.WriteLine(dob.ToLongDateString());      // Monday May 2022 
            // To print date time properties individually
            Console.WriteLine(dob.Day);       
            Console.WriteLine(dob.Month);      
            Console.WriteLine(dob.Year);
            Console.WriteLine(dob.Hour);         
            Console.WriteLine(dob.Minute);      
            Console.WriteLine(dob.Second);
            Console.WriteLine(dob.Millisecond);

            // Adding days 
            DateTime datea= dob.AddDays(10);
             Console.WriteLine(datea);

            // Printing current date
            DateTime today = DateTime.Now;            
            Console.WriteLine(today.ToString());

            // Subtracting date
            Console.WriteLine(dob.AddDays(-10));

            // To manipulate No of days, hours, mins sec based operations 
            TimeSpan span = new TimeSpan(10, 3, 3, 30);
                                        //Days, hours, minutes, secs
            Console.WriteLine(span.ToString(@"dd\:hh\:mm\:ss"));// span.ToString(format);

            TimeSpan timeSpan = DateTime.Now - new DateTime(1998,2,10);
            Console.WriteLine(" Age is :"+(int)timeSpan.TotalDays/365);

            // Printing the timespan properties
            Console.WriteLine(timeSpan.Days);//No of days
            Console.WriteLine(timeSpan.Hours);//No of hours
            Console.WriteLine(timeSpan.Minutes);//No of minuts
            Console.WriteLine(timeSpan.Seconds);// No of seconds
            Console.WriteLine(timeSpan.Milliseconds);// No of milliseconds
            
            // Getting values from user using parse exact
            Console.WriteLine(" Enter your date of birth dd/MM/yyyy format");
            DateTime doba = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);// Parse exact
            Console.WriteLine(doba.ToString("dd/MM/yyyy"));

            // Getting values from user and printing in US culture using parse exact
            CultureInfo provider = CultureInfo.CreateSpecificCulture("en-US");// US country english format
            Console.WriteLine(" Enter your date of birth dd/MM/yyyy format");
            DateTime dob1= DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",provider);
            Console.WriteLine(dob1.ToString("dd/MM/yyyy"));

            // DateTime with exception handling using try parse exact
            DateTime dob2 = new DateTime();
            Console.WriteLine(" Enter your date of birth dd/MM/yyyy format");
            bool valuea = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null,
       System.Globalization.DateTimeStyles.None, out dob2);
            Console.WriteLine(dob2);

            // DateTime with exception handling using try parse exact
            DateTime dobk = new DateTime();
            Console.WriteLine(" Enter your date of birth dd/MM/yyyy format");
            bool valuek = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null,
       System.Globalization.DateTimeStyles.AdjustToUniversal, out dobk);
            Console.WriteLine(dobk);

            // DateTime with exception handling using while  try parse exact
            DateTime dob3 = new DateTime();    
            Console.WriteLine(" Enter your date of birth dd/MM/yyyy format");
            bool value = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy",null, 
       System.Globalization.DateTimeStyles.None,out dob3);                          
            while(!value)
            {
                Console.WriteLine("Invalid Input re enter date in dd/MM/yyyy format ");
                value = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null,
       System.Globalization.DateTimeStyles.None, out dob3);
            }

            // Date time with try parse exact simplified
            DateTime datelimit;           
            Console.WriteLine("Enter Date in dd/MM/yyyy Format");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy",null, 
                System.Globalization.DateTimeStyles.None, out datelimit))
            { 
                Console.WriteLine("Invalid Date format input"); Console.WriteLine("Enter Date in dd/MM/yyyy Format");   
            }

            Console.WriteLine(datelimit.ToShortDateString());
            
            Console.ReadLine();
        }
    }
}
