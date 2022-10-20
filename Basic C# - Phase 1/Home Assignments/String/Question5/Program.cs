using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int count1=0; int count2=0 ;bool check=true;
        System.Console.WriteLine("Enter the First String: ");
        string string1 = Console.ReadLine();
        System.Console.WriteLine("Enter the Second String: ");
        string string2 = Console.ReadLine();
        foreach (char letter in string1)
        {
            count1++;
        }
        foreach (char letter in string2)
        {
            count2++;
        }
        if(count1 == count2)
        {
            for(int i=0 ; i<count1 ; i++)
            {
                if(string1[i] == string2[i])
                {
                    check = check && true;
                }
                else
                {
                    check = check && false ;
                }
            }
            if(check)
            {
                System.Console.WriteLine("Both Length And String Are Equal");
            }
            else
            {
                System.Console.WriteLine("Only Length is Equal");
            }
        }
        else
        {
            System.Console.WriteLine("Both String Are Different");
        }
    }
}