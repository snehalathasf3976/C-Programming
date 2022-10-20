using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the PassWord");
        string password = Console.ReadLine();
        if (password == "HiTeam")
        {
            System.Console.WriteLine("Right Password");
        }
        else
        {
            System.Console.WriteLine("Wrong Password");
        }
    }
}