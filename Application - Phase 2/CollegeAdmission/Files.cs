using System.IO;
namespace CollegeAdmission;
public static class Files
{
    public static void Create()
    {
        if(!Directory.Exists("College"))
        {
            Directory.CreateDirectory("College");
            System.Console.WriteLine("Folder Created Successfully");
        }
        if(!File.Exists("College/StudentDetails.csv"))
        {
            File.Create("College/StudentDetails.csv");
            System.Console.WriteLine("File Created Successfully");
        }
        if(!File.Exists("College/DepartmentDetails.csv"))
        {
            File.Create("College/DepartmentDetails.csv");
            System.Console.WriteLine("File Created Successfully");
        }
        if(!File.Exists("College/Admission.csv"))
        {
            File.Create("College/Admission.csv");
            System.Console.WriteLine("File Created Successfully");
        }
    }
    public static void ReadFile()
    {
        string[] students = File.ReadAllLines("College/StudentDetails.csv");

        foreach(string data in students)
        {
            StudentDetails student = new StudentDetails(data);
            Operations.studentList.Add(student);
        }

        string[] departments = File.ReadAllLines("College/DepartmentDetails.csv");

        foreach(string data in departments)
        {
            DepartmentDetails department = new DepartmentDetails(data);
            Operations.departmentList.Add(department);
        }

        string[] admissions = File.ReadAllLines("College/Admission.csv");

        foreach(string data in admissions)
        {
            AdmissionDetails admission = new AdmissionDetails(data);
            Operations.admissionList.Add(admission);
        }
    }
    public static void WriteToFile()
    {
        string[] studentDetails = new string[Operations.studentList.Count];
        for(int i=0 ; i<Operations.studentList.Count ; i++)
        {
            studentDetails[i] = Operations.studentList[i].StudentId+","+Operations.studentList[i].StudentName+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.studentList[i].StudentGender+","+Operations.studentList[i].PhysicsMark+","+Operations.studentList[i].ChemistryMark+","+Operations.studentList[i].MathsMark;
        }
        File.WriteAllLines("College/StudentDetails.csv",studentDetails);

        string[] departmentDetails = new string[Operations.departmentList.Count];
        for(int i=0 ; i<Operations.departmentList.Count ; i++)
        {
            departmentDetails[i] = Operations.departmentList[i].DepartmentId+","+Operations.departmentList[i].DepartmentName+","+Operations.departmentList[i].NumberOfSeats;
        }
        File.WriteAllLines("College/DepartmentDetails.csv",departmentDetails);

        string[] admissionDetails = new string[Operations.admissionList.Count];
        for(int i=0 ; i<Operations.admissionList.Count ; i++)
        {
            admissionDetails[i]=Operations.admissionList[i].AdmissionId+","+Operations.admissionList[i].StudentId+","+Operations.admissionList[i].DepartmentId+","+Operations.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operations.admissionList[i].AdmissionStatus;
        }
        File.WriteAllLines("College/Admission.csv",admissionDetails);
    }
}