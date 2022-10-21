using System;
using System.IO;
namespace ReadWriteTxtFile;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder Created Successfully");
        }
        else
        {
            System.Console.WriteLine("Folder Exist");
        }
        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File Created Successfully");
        }
        else
        {
            System.Console.WriteLine("File Created Successfully");
        }
        System.Console.WriteLine("Select Option to Perform \n1.Read Info \n2.Write Info");
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                string line;
                StreamReader read = null; //StreamReader is to Read the Text File
                try
                {
                    //Pass the File Path and File name to the StreamReader Constructor
                    read = new StreamReader("TestFolder/Test.txt");
                    //Read the first Line of the text
                    line = read.ReadLine();
                    while(line != null )
                    {
                        System.Console.WriteLine(line);  // Write the Readed line from the text file to Console Window
                        line = read.ReadLine();
                    }
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception: "+e.Message);
                }
                finally
                {
                    if(read != null)
                    {
                        System.Console.WriteLine("Executing Finally Block");
                    }
                    read.Close();
                }
                break;
            }
            case 2:
            {
                StreamWriter write = null ;
                try
                {
                    string[] existingFile = File.ReadAllLines("TestFolder/Test.txt");
                    //Pass the File name And File Pathe to the Streamwriter Constructor in order to Make Changes to the File
                    write = new StreamWriter("TestFolder/Test.txt");
                    System.Console.WriteLine("Enter the Contents To be Added in the File");
                    string addingContent = Console.ReadLine();
                    string newFile = "";
                    foreach(string text in existingFile)
                    {
                        newFile = newFile +"\n" + text; //Converting the Whole Text File into Single String
                    }
                    newFile = newFile + "\n" + addingContent; //Appending User Input to the File
                    write.WriteLine(newFile);
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Error is: "+e.Message);
                }
                finally
                {
                    if(write != null)
                    {
                        write.Close();
                    }
                }
                break;
            }
        }
    }
}