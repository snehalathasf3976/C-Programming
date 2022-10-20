using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Limit:");
        int limit = int.Parse(Console.ReadLine());
        System.Console.WriteLine("ArmStrong Numbers are: ");
        for(int i=1 ; i<limit ; i++)
        {
            ArmStrong(i);
        }
        void ArmStrong(int num)
        {
            int sum = 0;
            int temp = num;
            if(num < 10)
            {
                System.Console.Write(num+"\t");
            }
            else
            {
                while(num>0)
            {
                int digit = num % 10;
                sum = sum + (digit*digit*digit);
                num = num /10;
            }
            if(temp == sum)
            {
                System.Console.Write(temp+"\t");
            }
            }
        } 
    }
}