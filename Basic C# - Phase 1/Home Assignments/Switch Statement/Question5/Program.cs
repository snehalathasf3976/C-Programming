using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("1.India \n2.Pakistan \n3.Bangladesh \nSelect the Team");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
            {
                System.Console.WriteLine("1.MS Dhoni \n2.Virat Kohli \n3.Sachin Tendulkar");
                break;
            }
            case 2:
            {
                System.Console.WriteLine("1.babar azam \n2.Mohammad Haffez \n3.Younis Khan");
                break;
            }
            case 3:
            {
                System.Console.WriteLine("1.Shakib AL Hasan \n2.Mushfiqur Rahim \n3.Tamim Iqbal");
                break;
            }
            default:
                System.Console.WriteLine("Invalid Data");
                break;
        }
        
    }
}