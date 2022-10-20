using System;
namespace PayRollManagement
{
    public enum Gender { Default , Male , Female ,Transgender}
    public class PayRollDetails
    {
        public static int s_employeeId = 1000 ;
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeRole { get; set; }
        public string EmployeeWorkLocation { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int NumberOfWorkedDays { get; set; }
        public int NumberOfLeaveTaken{ get; set; }
        public Gender EmployeeGender { get; set; }

        public PayRollDetails(string name , string employeeRole , string employeeWorkLocation ,DateTime dateOfJoining , int numberOfWorkedDays , int numberOfLeaveTaken , Gender gender)
        {
            s_employeeId++;
            EmployeeId = "EID" + s_employeeId ;
            EmployeeName = name ;
            EmployeeRole = employeeRole;
            EmployeeWorkLocation = employeeWorkLocation ;
            DateOfJoining =dateOfJoining ;
            NumberOfWorkedDays = numberOfWorkedDays ;
            NumberOfLeaveTaken = numberOfLeaveTaken ;
            EmployeeGender = gender ; 
        }
        public int CalculateSalary(int numberOfWorkedDays)
        {
            //int days = totalMonthDays - numberOfLeaveTaken ;
            int salary = 500 * numberOfWorkedDays; 
            return salary ;
        }
    }
}