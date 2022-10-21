namespace AbstractClass;
public abstract class Employee
{
    protected string name; //Normal Field
    public abstract string Name { get; set; } //Abstract Property
    public double Amount { get; set; } //Normal Property
    public void Displyay(){ System.Console.WriteLine(name); } // Normal Method
    public abstract void Salary(int dates); //Abstract Method
}