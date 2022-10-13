using System;
namespace EnumTypes;
public enum Gender { Default ,Male , Female , Transgender }
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Select the Gender , Male , Female , Transgender");
        Gender gender1 = Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine(gender1);
        
        Gender gender2 = Gender.Default;
        bool temp = Enum.TryParse<Gender>(Console.ReadLine(),true, out gender2);
        while(!temp || !((int) gender2<4 && (int) gender2>0))
        {
            System.Console.WriteLine("Invalid Gender!!!  Enter Again");
            temp = Enum.TryParse<Gender>(Console.ReadLine(),true, out gender2);
        }
    }
}