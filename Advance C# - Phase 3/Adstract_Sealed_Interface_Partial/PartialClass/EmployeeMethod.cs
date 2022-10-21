using System;
namespace PartialClass;
public partial class Employee
{
    public Employee(int employeeId , string name)
    {
        this.EmployeeId = employeeId ;
        this.Name = name ;
    }

    public void Display()
    {
        System.Console.WriteLine("Id is: "+EmployeeId+"\nName is: "+Name);
    }
}