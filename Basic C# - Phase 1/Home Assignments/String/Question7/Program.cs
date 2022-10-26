using System;
using System.Collections.Generic;
namespace BankApplication;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the String");
        string string1 = Console.ReadLine();
        int vowels = 0 ; int alphabet = 0 , number = 0 ;
        for(int i=0 ; i<string1.Length ; i++)
        {
            if(string1[i] == 'e' || string1[i] == 'a' || string1[i] == 'i' || string1[i] == 'o'|| string1[i] == 'u' || string1[i] == 'E' || string1[i] == 'A' || string1[i] == 'I' || string1[i] == 'O'|| string1[i] == 'U')
            {
                vowels++;
            }
            else if((string1[i] >= 'a') && (string1[i] <= 'z') || ((string1[i] >= 'A') && (string1[i] <= 'Z')))
            {
                alphabet++;   
            }
        }
        System.Console.WriteLine("Alphabet is: "+alphabet);
        System.Console.WriteLine("Vowel is: "+vowels);
    }
}