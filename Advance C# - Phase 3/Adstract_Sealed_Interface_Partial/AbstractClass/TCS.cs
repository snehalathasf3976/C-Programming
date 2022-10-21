namespace AbstractClass;
public class TCS: Employee
{
    public override string Name { get{return name ;} set{name = value; } } 
    //Abstract Method Definition
    public override void Salary(int dates)
    {
        Displyay();
        Amount = (double) dates * 300 ;
        System.Console.WriteLine("Salary is: "+Amount);
    }
}