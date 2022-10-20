using System;
using System.Collections.Generic;
namespace BloodBankManagement;
public class Operations
{
    static List<UserRegistration> userList = new List<UserRegistration>();
    static List<Donation> donorList = new List<Donation>();
    public static void DefaultDetails()
    {
        userList.Add(new UserRegistration( "RaviChandran" , 9876543210 , BloodGroup.O_Positive , 30 , "Theni" ));
        userList.Add(new UserRegistration( "Baskar" , 9012345678 , BloodGroup.AB_Positive , 30 , "Chennai" ));

        donorList.Add(new Donation("UID1001" ,new DateTime(2022,06,10) , 73 , 120 , 14));
        donorList.Add(new Donation("UID1001" ,new DateTime(2022,10,10) , 74 , 120 , 14));
        donorList.Add(new Donation("UID1002" ,new DateTime(2022,07,11) , 74 , 120 , 13.6));
        
    }
    public static void MainMenu()
    {
        string condition = "YES";
        do
        {
            System.Console.WriteLine("Select the Option to Perform(1-3) \n1.User Registration \n2.User Login \n3.Exit");
            int choice = int.Parse (Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Registration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    condition = "no";
                    break;
                }
                default:
                {
                    System.Console.WriteLine("NO such Option Select Within 1-3");
                    break;
                }
            }
                
        } while (condition == "YES");

    } 
    static void Registration()
    {
        System.Console.WriteLine("\n\n  Registration    \n\n");
        System.Console.WriteLine("Enter the Name");
        string name = Console.ReadLine();

        System.Console.WriteLine("Enter Your Age");
        int age = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your Mobile Number");
        long mobileNumber = int.Parse (Console.ReadLine());

        System.Console.WriteLine("Enter Your Blood Group (O_Positive/A_Positive/B_Positive/AB_Positive))");
        BloodGroup bloodGroup = Enum.Parse<BloodGroup>(Console.ReadLine(),true);
        
        System.Console.WriteLine("Enter your Native Place: ");
        string native = Console.ReadLine();
        
        UserRegistration user = new UserRegistration(name , mobileNumber , bloodGroup , age , native);
        userList.Add(user);
        System.Console.WriteLine("Registration Successfull!!! \n Your User Id is: "+user.DonorId);
    }
    static void Login()
    {
        System.Console.WriteLine("\n\n  Login   \n\n");
        System.Console.WriteLine("Enter Your User Id");
        string donorId = Console.ReadLine().ToUpper();
        int count=0;
        foreach(UserRegistration user in userList)
        {
            if(user.DonorId == donorId)
            {
                System.Console.WriteLine("Valid User");
                count = 1;
                Submenu(user);
            }
        }
        if(count == 0)
        {
            System.Console.WriteLine("Invalid User");
        }
    }
    static void Submenu(UserRegistration user)
    {
        System.Console.WriteLine("\n\nSub Menu\n\n");
        string condition = "YES";
        do
        {
            System.Console.WriteLine("Enter Your Operation to do(1-4) \n1.Donate Blood \n2.Donation History \n3.Next Eligible Date \n4.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    DonateBlood(user);
                    break;
                }
                case 2:
                {
                    DonationHistory(user);
                    break;
                }
                case 3:
                {
                    DateTime date = NextEligibleDate(user);
                    System.Console.WriteLine("Your Next Eligible Date is: "+date.ToString("dd/MM/yyyy"));
                    break;
                }
                case 4:
                {
                    condition = "no";
                    break;
                }
                default:
                {
                    System.Console.WriteLine("No Such Option Select Within 1-4");
                    break;
                }
            }
        }while(condition == "YES");
    }
    static void DonationHistory(UserRegistration user)
    {
        System.Console.WriteLine("|Donation Id | Donor Id | Donation Date | Weight | Blood Pressure | Hemoglobin |");
        foreach(Donation donation in donorList)
        {
            if(donation.DonorId == user.DonorId)
            {
                System.Console.WriteLine($"|{donation.DonationId , -11} | {donation.DonorId , -8} | {donation.DonationDate.ToString("dd/MM/yyyy") , -13} | {donation.Weight , -6} | {donation.BloodPressure , -14} | {donation.Hemoglobin , -10} |");
            }
        }
    }
    static void DonateBlood(UserRegistration user)
    {
        System.Console.WriteLine("Enter Your Weight: ");
        int weight = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your Blood Pressure: ");
        int bloodPressure = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your Hemoglobin: ");
        int hemoglobin = int.Parse(Console.ReadLine());
        int count = 0 ;
        if(weight > 50  &&  bloodPressure < 130  &&  hemoglobin>13)
        {
            DateTime date = new DateTime(01,01,0001);
            foreach(Donation donation in donorList)
            {
                if(user.DonorId == donation.DonorId)
                {
                    date = donation.DonationDate;
                }
            }
            TimeSpan checkDate = DateTime.Now - date;
            if(checkDate.Days >= 60)
                {
                    count = 1;
                }
                
            if(count == 1)
            {
                Donation donor = new Donation(user.DonorId , DateTime.Now , weight , bloodPressure , hemoglobin);
                donorList.Add(donor);
                System.Console.WriteLine("Donation Successfull!!! \nYour Donation Id is: "+donor.DonationId);
            }
            else
            {
                System.Console.WriteLine("Your Not Eligible to Donate");
            }
        }
    }
    static DateTime NextEligibleDate(UserRegistration user)
    {
        DateTime date = new DateTime(01,01,0001);
        foreach(Donation donation in donorList)
        {
            if(user.DonorId == donation.DonorId)
            {
                date = donation.DonationDate;
            }
        }
        date = date.AddDays(60);
        return date;
    }
}