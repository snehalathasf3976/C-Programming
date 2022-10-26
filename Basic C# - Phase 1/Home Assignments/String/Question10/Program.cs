using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Set the User Name");
        string userName = Console.ReadLine();
        System.Console.WriteLine("Set the PassWord");
        string password = Console.ReadLine();
        System.Console.WriteLine("Enter the user Name");
        string checkUserName = Console.ReadLine();
        System.Console.WriteLine("Enter the Password");
        string checkPassWord = Console.ReadLine();
        int count = 0 , temp =0 ;
        for(int i=0 ; i<userName.Length ; i++)
        {
            if(checkUserName[i] != userName[i])
            {
                count++;
            }
        }
        for(int i=0 ; i<password.Length ; i++)
        {
            if(checkPassWord[i] != password[i])
            {
                temp++;
            }
        }
        if(count == 0)
        {
            if(temp == 0)
            {
                System.Console.WriteLine("Correct Password and User Name");
            }
        }
        else
        {
            System.Console.WriteLine("Invalid Credential");
        }
    }
}