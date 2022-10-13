using System;
namespace ArrayAssignments;
class Program
{
    public static void Main(string[] args)
    {
        string[] name = {"sneha" , "swetha" , "arthi" , "brundha" , "divya"};
        System.Console.WriteLine("Name in Array are: ");
        int count = 0;
        for (int i=0 ; i<name.Length ; i++)
        {
            System.Console.WriteLine(name[i]);
        }
        System.Console.WriteLine("Enter the name to Search in the Array");
        string search = Console.ReadLine();
        System.Console.WriteLine("This is using For Loop"); 
        for (int i=0 ; i<name.Length ; i++)
        {
            if(name[i] == search)
            {
                count++;
                System.Console.WriteLine("The Given Name {0} is Presented at {1}",search,i);
            }
        }
        if(count == 0)
            {
                System.Console.WriteLine(" The Name is Not Present in array");
            }
        int count1 = 0;
        System.Console.WriteLine("This is using For Each");
        foreach (string temp in name)
        {
            if(temp == search)
            {
                count1++;
                System.Console.WriteLine("The Given Name {0} is Presented in the Array",search);
            }
        }
        if(count1 == 0)
        {
            System.Console.WriteLine(" The Name is Not Present in array");
        }
    }
}