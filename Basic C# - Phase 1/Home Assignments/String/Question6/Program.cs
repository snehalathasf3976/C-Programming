using System;
using System.Collections.Generic;
namespace BankApplication;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the String");
        string string1 = Console.ReadLine();
        int specialCharacter = 0 ; int alphabet = 0 , number = 0 ;
        for(int i=0 ; i<string1.Length ; i++)
        {
            if((string1[i] >= 'a') && (string1[i] <= 'z') || ((string1[i] >= 'A') && (string1[i] <= 'Z')))
            {
                alphabet++;   
            }
            else if(string1[i] >= '0' && string1[i] <= '9')
            {
                number ++;
            }
            else
            {
                specialCharacter++;
            }
        }
        System.Console.WriteLine("Alphabet is: "+alphabet);
        System.Console.WriteLine("Vowel is: "+specialCharacter);
        System.Console.WriteLine("Number is: "+number);
    }
}