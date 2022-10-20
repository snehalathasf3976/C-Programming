using System;
using System.Collections.Generic;
namespace BankApplication;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the String");
        string string1 = Console.ReadLine();
        int count = 0 ; int count1 = 0;
        for(int i=0 ; i<string1.Length ; i++)
        {
            if(string1[i] == 'e' || string1[i] == 'a' || string1[i] == 'i' || string1[i] == 'o'|| string1[i] == 'u')
            {
                count++;
            }
            else
            {
                //if
            }
        }
    }
}