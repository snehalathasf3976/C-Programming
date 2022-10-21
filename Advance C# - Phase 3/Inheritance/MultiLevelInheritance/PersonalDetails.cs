using System;
namespace MultiLevelInheritance;
public enum Gender{Default , Male , Female }
public class PersonalDetails
{
    static int s_aId = 1000;
    public string AId { get; set; }
    public string Name { get; set; }
    public string FatherName { get; set; }
    public Gender Gender { get; set; }
    public string MobileNumber { get; set; }

    public PersonalDetails( string name , string fatherName , Gender gender , string mobileNumber)
    {
        s_aId++;
        AId = "AID" + s_aId ;
        Name = name ;
        FatherName = fatherName ; 
        Gender = gender ; 
        MobileNumber = mobileNumber ;
    }
    public PersonalDetails(string aid , string name , string fatherName , Gender gender , string mobileNumber)
    {
        AId = aid ; 
        Name = name ;
        FatherName = fatherName ; 
        Gender = gender ; 
        MobileNumber = mobileNumber ;

    }

    public void ShowDetails()
    {
        System.Console.WriteLine("Id is: "+AId);
        System.Console.WriteLine("Name is: "+Name);
        System.Console.WriteLine("FatherName is: "+FatherName);
        System.Console.WriteLine("Gender is: "+Gender);
        System.Console.WriteLine("Mobile Number is: "+MobileNumber);
    }
}