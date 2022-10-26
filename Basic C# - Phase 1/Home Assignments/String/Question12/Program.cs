using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Main String: ");
        string mainString = Console.ReadLine();
        string[] number = mainString.Split(' ');
        int max = 0 , min = 9 ;
        for(int i=0 ; i<number.Length ; i++)
        {
            int temp = int.Parse(number[i]);
            if(temp > max)
            {
                max = temp;
            }
            if(temp < min)
            {
                min = temp;
            }
        }
        System.Console.WriteLine("Max is: "+max+" Min is: "+min);
    }
}