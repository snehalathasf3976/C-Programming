using System;
using System.IO;
using System.Collections.Generic;
namespace ReadWriteCsvFile;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            System.Console.WriteLine("Folder Already Exist");
        }
        if(!File.Exists("TestFolder/Data.csv"))
        {
            File.Create("TestFolder/Data.csv");
        }
        else
        {
            System.Console.WriteLine("File Already Exist");
        }
        List<Student> studentList = new List<Student>();
        studentList.Add(new Student(){Name = "Sneha" , FatherName = "Venkatason" , Gender=Gender.Female , DOB=new DateTime(2001,05,17)});
        studentList.Add(new Student(){Name = "Nivedha" , FatherName = "Velmurugam" , Gender=Gender.Female, DOB=new DateTime(2000,09,05)});
        studentList.Add(new Student(){Name = "Swetha" , FatherName = "Sekar" , Gender=Gender.Female , DOB=new DateTime(2001,07,01)});
        Insert(studentList);
        Display();
        ///Update();
    }
    static void Insert(List<Student> student)
    {
        StreamWriter write = null;
        write = new StreamWriter(File.OpenWrite("TestFolder/Data.csv"));
        foreach(Student details in student)
        {
            write.WriteLine(details.Name+","+details.FatherName+","+details.Gender+","+details.DOB.ToString("dd/MM/yyyy"));
        }
        write.Close();
    }
    static void Display()
    {
        StreamReader read = null;
        List<Student> studentList = new List<Student>();
        if(File.Exists("TestFolder/Data.csv"))
        {
            read = new StreamReader(File.OpenRead("TestFolder/Data.csv"));
            while(!read.EndOfStream)
            {
                var line = read.ReadLine();
                var values = line.Split(',');
                if(values[0]!= "")
                {
                    studentList.Add(new Student(){Name= values[0] , FatherName = values[1] , Gender=Enum.Parse<Gender>(values[2]) , DOB = DateTime.ParseExact(values[3] , "dd/MM/yyyy",null) });
                }
            }
        }
        else
        {
            System.Console.WriteLine("File Doesn't Exist");
        }
        read.Close();
        foreach(var coloum in studentList)
        {
            System.Console.WriteLine("Name is: "+coloum.Name+"\tFather Name is: "+coloum.FatherName+ "\tGender is: "+coloum.Gender+"\tDate Of Birth is: "+coloum.DOB);
        }
    }
}