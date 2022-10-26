using System;
using System.IO;
namespace FileFolder;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\SnehalathaVenkatason\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath  = path+"/Sneha";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder Not Found!!! So Creating New Folder");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            System.Console.WriteLine("Directory Found");
        }
        string filePath = path + "/newFile.txt";
        if(!File.Exists(filePath))
        {
            System.Console.WriteLine("File Not Found!!! So Creating New File");
            File.Create(filePath);
        }
        else
        {
            System.Console.WriteLine("File Found");
        }
        System.Console.WriteLine("Select Option \n1.Create Folder \n2.Create File \n3.Delete Folder \n4.Delete File");
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine("Enter Folder Name You Want to Create: ");
                string folderName = Console.ReadLine();
                string newPath = path + "\\" +folderName;
                if(!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                    System.Console.WriteLine("Directory Not Found So Creating a Folder");
                }
                else
                {
                    System.Console.WriteLine("Directory Already Exists");
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter File Name You Want to Create");
                string fileName = Console.ReadLine();
                System.Console.WriteLine("Enter File Extension You Want to Add");
                string extension = Console.ReadLine();
                string newPath = path +"\\"+fileName+"."+extension ;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                    System.Console.WriteLine("File Not Found So Creating a File");
                }
                else
                {
                    System.Console.WriteLine("File Already Exits");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select Folder You Want to Delete");
                string name1 = Console.ReadLine();
                string newPath = path+"\\"+name1;
                try
                {
                    foreach(string name in Directory.GetDirectories(path))
                    {
                        if(name == newPath)
                        {
                            Directory.Delete(newPath);
                            System.Console.WriteLine("Folder Deleted");
                        }
                    }
                }
                catch(DirectoryNotFoundException e)
                {
                    System.Console.WriteLine("Directory Not Found");
                }
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select File You Want to Delete: ");
                string name1 = Console.ReadLine();
                System.Console.WriteLine("Enter File Extension You Want to Delete");
                string extension = Console.ReadLine();
                string newPath = path+"\\"+name1+"."+extension;
                try
                {
                    foreach(string name in Directory.GetFiles(path))
                    {
                        if(name == newPath)
                        {
                            File.Delete(newPath);
                            System.Console.WriteLine("File Deleted Successfully");
                        }
                    }
                }
                catch(FileNotFoundException e)
                {
                    System.Console.WriteLine("File Not Found");
                }
                break;
            }
        }
    }
}