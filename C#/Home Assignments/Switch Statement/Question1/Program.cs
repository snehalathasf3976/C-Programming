﻿using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Grade");
        char grade = char.Parse(Console.ReadLine());
        switch(grade)
        {
            case 'E':
            {
                System.Console.WriteLine("Excellent");
                break;
            }
            case 'V':
            {
                System.Console.WriteLine("Very Good");
                break;
            }
            case 'G':
            {
                System.Console.WriteLine("Good");
                break;
            }
            case 'A':
            {
                System.Console.WriteLine("Average");
                break;
            }
            case 'F':
            {
                System.Console.WriteLine("Fail");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid Grade");
                break;
            }
        }
    }
}