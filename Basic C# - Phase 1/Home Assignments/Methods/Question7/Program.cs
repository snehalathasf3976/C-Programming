using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the String");
        string name = Console.ReadLine();
        bool temp = true ;
        int l=name.Length;
        foreach(char letter in name)
        {
            l--;
            temp = temp && Palindrome(name , letter ,l);
        }
        if(temp)
        {
            System.Console.WriteLine("Palindrome");
        }
        else
        {
            System.Console.WriteLine("Not Palindrome");
        }

    bool Palindrome(string name , char num , int l)
    {
        if(num == name[l])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
}