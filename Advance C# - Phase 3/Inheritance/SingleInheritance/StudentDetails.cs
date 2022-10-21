namespace SingleInheritance;
public enum Department {Default , EEE , ECE , CSE}
public class StudentDetails:PersonalDetails
{
    static int s_studentId = 1000 ;
    public string StudentId { get; set; }
    public Department Department { get; set; }
    public string Year { get; set; }

    public StudentDetails( string aid , string name , string fatherName , Gender gender , string mobileNumber , Department department , string year ):base(aid , name , fatherName , gender , mobileNumber)
    {
        s_studentId++;
        StudentId = "SID" + s_studentId ;
        Department = department ;
        Year = year ;
    }

    public void ShowStudent()
    {
        System.Console.WriteLine("Student Id is: "+StudentId);
        ShowDetails();
        System.Console.WriteLine("Depatment is: "+Department);
        System.Console.WriteLine("Year is: "+Year);
    }
}