namespace MultiPathInheritance;
class Student : IAcademic , ISport
{
    public int AcademicMark { get; set; }
    public string Name { get; set; }
    public int SportMark { get; set; }
    public Student(string name , int sportMark , int academicMark )
    {
        Name = name ;
        SportMark = sportMark ;
        AcademicMark = academicMark ;
    }

    public void Display()
    {
        System.Console.WriteLine("Name is: "+Name+"\nSports Marks is: "+SportMark+"\nAcademic Mark is: "+AcademicMark);
        
    }
}