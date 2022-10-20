namespace CollegeAdmission;
public class DepartmentDetails
{
    static int s_departmentId = 1000 ;
    public string DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public int NumberOfSeats { get; set; }

    public DepartmentDetails(string name , int numberOfSeats)
    {
        s_departmentId++;
        DepartmentId = "DID" + s_departmentId ; 
        DepartmentName = name ;
        NumberOfSeats = numberOfSeats ;
    }

    public DepartmentDetails(string data)
    {
        string[] values = data.Split(',');
        s_departmentId = int.Parse(values[0].Remove(0,3));
        DepartmentId = values[0];
        DepartmentName = values[1];
        NumberOfSeats =int.Parse(values[2]);
    }
}