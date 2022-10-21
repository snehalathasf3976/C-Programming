namespace MultipleInheritance;
public enum Department {Default , EEE , ECE , CSE}
public class StudentDetails:PersonalDetails,IMarkDetails
{
    static int s_studentId = 1000 ;
    public string StudentId { get; set; }
    public Department Department { get; set; }
    public string Year { get; set; }

    public int Physics { get; set; }
    public int Chemistry { get; set; }
    public int Maths { get; set; }
    public int Total { get; set; }
    public double Average { get; set; }

    public void GetMark(int physics , int chemistry , int maths)
    {
        Physics = physics;
        Chemistry = chemistry ;
        Maths = maths ;
    }

    public void Calculate()
    {
        Total = Physics + Chemistry + Maths ;
        Average = (double) Total/3.0 ;
    }

    public void ShowMark()
    {
        System.Console.WriteLine("Physics Mark is: "+Physics);
        System.Console.WriteLine("Chemistry Mark is: "+Chemistry);
        System.Console.WriteLine("Maths Mark is: "+Maths);
        System.Console.WriteLine("Total Mark is: "+Total);
        System.Console.WriteLine("Average is: "+Average);
    }

    public StudentDetails( string aid , string name , string fatherName , Gender gender , string mobileNumber , Department department , string year ):base(aid , name , fatherName , gender , mobileNumber)
    {
        s_studentId++;
        StudentId = "SID" + s_studentId ;
        Department = department ;
        Year = year ;
    }

    public StudentDetails(string studentId , string aid , string name , string fatherName , Gender gender , string mobileNumber , Department department  ):base(aid , name , fatherName , gender , mobileNumber)
    {
        StudentId = studentId;
        Department = department ;
    }

    public void ShowStudent()
    {
        System.Console.WriteLine("Student Id is: "+StudentId);
        ShowDetails();
        System.Console.WriteLine("Depatment is: "+Department);
        System.Console.WriteLine("Year is: "+Year);
    }
}