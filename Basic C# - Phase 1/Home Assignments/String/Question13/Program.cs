using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Main String: ");
        string mainString = Console.ReadLine();
        string result = "";
        for (int i=0 ;  i<mainString.Length ;i++)
        {
            for(int j=i+1 ; j<mainString.Length-1 ;j++ )
            {
                if(mainString[i] == mainString[j])
                {
                    mainString.Replace(mainString[i],' ');
                    continue;
                }
                else
                {
                    //result = String.Concat(result,mainString[i]);
                }
            }
        }
        System.Console.WriteLine(mainString);
        //System.Console.WriteLine(result);
    }
}