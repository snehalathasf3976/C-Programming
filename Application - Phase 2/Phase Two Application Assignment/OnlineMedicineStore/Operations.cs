using System;
using System.Collections.Generic ;
namespace OnlineMedicineStore;
public class Operations
{
    static List<UserDetails> userList = new List<UserDetails>();
    static List<MedicineDetails> medicineList = new List<MedicineDetails>();
    static List<OrderDetails> orderList = new List<OrderDetails>();
    public static void MainMenu()
    {
        System.Console.WriteLine("\n          ***************************");
        System.Console.WriteLine("          Online Medicine Application");
        System.Console.WriteLine("          ***************************");
        string condition = "YES";
        do
        {
            System.Console.WriteLine("\nEnter the Operation to do \n1.Registration \n2.Login \n3.Exit");
            int choice = int.Parse(Console.ReadLine());
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
                    System.Console.WriteLine("Invalid Operation \nEnter Number Between 1-3");
                    break;
                }
            }
        }while(condition == "YES");
    }


    static void Registration()
    {
        System.Console.WriteLine("\n***** Registration ******\n");

        System.Console.WriteLine("Enter Your Name: ");
        string name = Console.ReadLine();
        
        System.Console.WriteLine("Enter You Age: ");
        int age = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your City: ");
        string city = Console.ReadLine();
        
        System.Console.WriteLine("Enter Your Phone Number: ");
        long mobileNumber = long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your Balance: ");
        int balance = int.Parse(Console.ReadLine());

        UserDetails user = new UserDetails(name , age , city , mobileNumber , balance);
        userList.Add(user);
        System.Console.WriteLine("\nRegistration Successfull!!! Your User Id is: "+user.UserId);
    }


    static void Login()
    {
        System.Console.WriteLine("\n***** Login ******\n");

        System.Console.WriteLine("Enter Your User Id");
        string userId = Console.ReadLine().ToUpper();
        int count = 0 ;
        foreach(UserDetails user in userList)
        {
            if(user.UserId == userId)
            {
                System.Console.WriteLine("Valid User Id");
                SubMenu(user);
                count = 1;
            }
        }
        if(count == 0)
        {
            System.Console.WriteLine("Invalid User Id!!! Please Enter the Proper User Id To Login");
        }
    }


    static void SubMenu(UserDetails user)
    {
        System.Console.WriteLine("\n***** WELCOME!!! *****\n");
        string condition = "YES";
        do
        {
            System.Console.WriteLine("Enter the Process to Do: \n1.Show Medicine List \n2.Purchase Medicine \n3.Cancel Purchase \n4.Show Purchase History \n5.Recharge \n6.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    ShowMedicineList(user);
                    break;
                }
                case 2:
                {
                    PurchaseMedicine(user);
                    break;
                }
                case 3:
                {
                    CancelPurchase(user);
                    break;
                }
                case 4:
                {
                    ShowPurchaseHistory(user);
                    break;
                }
                case 5:
                {
                    Recharge(user);
                    break;
                }
                case 6:
                {
                    condition = "no";
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid Operation \nEnter Number Between 1-6");
                    break;
                }
            }
        }while(condition == "YES");
    }


    static void ShowMedicineList(UserDetails user)
    {
        System.Console.WriteLine("\n***** Medicine List *****\n");

        System.Console.WriteLine("|---------------------------------------------------------------------| ");
        System.Console.WriteLine("| Medicine Id | Medicine Name | Available Count | Price | Expiry Date |");
        System.Console.WriteLine("|---------------------------------------------------------------------| ");
        foreach(MedicineDetails medicine in medicineList)
        {
            System.Console.WriteLine($"| {medicine.MedicineId , -11} | {medicine.MedicineName , -13} | {medicine.AvailableCount , -15} | {medicine.Price , -5} | { medicine.DateofExpiry.ToString("dd/MM/yyyy") , -11} |");
        }
        System.Console.WriteLine("|---------------------------------------------------------------------| ");
        System.Console.WriteLine();
    }

    static void PurchaseMedicine(UserDetails user)
    {
        System.Console.WriteLine("\n***** Purchase Medicine *****\n");

        ShowMedicineList(user);
        System.Console.WriteLine("Enter the Medicine Id Which You Want To Select: ");
        string medicineId = Console.ReadLine().ToUpper();
        System.Console.WriteLine("Enter the Number of Medicine You Want(Quantity): ");
        int count = int.Parse(Console.ReadLine());
        int flag = 0 , temp = 0 , price = 1;
        
        foreach(MedicineDetails medicine in medicineList)
        {
            if(medicine.MedicineId == medicineId)
            {
                flag = 1;
                if(medicine.AvailableCount >= count )
                {
                    price = medicine.Price * count ;
                    if(user.Balance >= price)
                    {
                        TimeSpan checkDate = medicine.DateofExpiry - DateTime.Now ;
                        if(checkDate.Days > 0)
                        {
                            medicine.AvailableCount = medicine.AvailableCount - count ;
                            user.Balance = user.Balance - price ; 
                            temp = 1;
                        }
                        else
                        {
                            System.Console.WriteLine("Medicine Expired!!! Wait Till Restocked \n");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("You Don't Have Sufficient Balance!!! Recharege Inorder To Purchase\n");
                    }
                }
                else
                {
                    System.Console.WriteLine("Medicine Count Not Available!!! Available stock is "+medicine.AvailableCount+"\n");
                }
            }

        }
        if(flag == 0)
        {
            System.Console.WriteLine("Invalid Id Please Enter the Valid Id\n");
        }
        if(temp == 1)
        {
            OrderDetails order = new OrderDetails(user.UserId , medicineId , count , price , DateTime.Now , OrderStatus.Purchased );
            orderList.Add(order);
            System.Console.WriteLine("Medicine Purchased Successfully!!! Your Order Id is: "+order.OrderId);
            System.Console.WriteLine($"{price}rs Deducted from Your Balance!!! Your Current Balance is: "+user.Balance+"\n");
        }
    }

    static void CancelPurchase(UserDetails user)
    {
        System.Console.WriteLine("\n***** Cancel Purchase *****\n");

        ShowPurchaseHistory(user);
        System.Console.WriteLine("Select the Order Id to Cancel the Purchase");
        string orderId = Console.ReadLine().ToUpper();
        int flag = 0 , temp = 0;
        foreach (OrderDetails order in orderList)
        {
            if(order.OrderId == orderId ) 
            {
                flag = 1;
                if(order.OrderStatus == OrderStatus.Purchased)
                {
                    temp = 1;
                    foreach(MedicineDetails medicine in medicineList)
                    {
                        if(medicine.MedicineId == order.MedicineID)
                        {
                            medicine.AvailableCount = medicine.AvailableCount + order.MedicineCount ;
                            user.Balance = user.Balance + order.TotalPrice ; 
                            order.OrderStatus = OrderStatus.Cancelled ;
                            System.Console.WriteLine($"{order.OrderId} Cancelled Successfully And The Amount Is Deposited in Your Balance\n");
                        }
                    }
                }
            }
        }
        if(flag == 0)
        {
            System.Console.WriteLine("Enter Proper Id To Cancel the Purchase");
        }
        if(temp == 0)
        {
            System.Console.WriteLine("Order Already Cancelled");
        }
    }

    static void ShowPurchaseHistory(UserDetails user)
    {
        System.Console.WriteLine("\n***** Purchase History *****\n");

        System.Console.WriteLine("|---------------------------------------------------------------------------------------------| ");
        System.Console.WriteLine("| Order Id | User Id | Medicine Id | Medicine Count | Total Price | Order Date | Order Status |");
        System.Console.WriteLine("|---------------------------------------------------------------------------------------------| ");
        foreach(OrderDetails order in orderList)
        {
            if(order.UserId == user.UserId)
            {
                System.Console.WriteLine($"| {order.OrderId , -8 } | { order.UserId , -7} | {order.MedicineID , -11} | {order.MedicineCount , -14} | {order.TotalPrice , -11} | {order.OrderDate.ToString("dd/MM/yyyy") , -10} | { order.OrderStatus , -12} |");
            }
        }
        System.Console.WriteLine("|---------------------------------------------------------------------------------------------| ");
        System.Console.WriteLine();
    }


    static void Recharge(UserDetails user)
    {
        System.Console.WriteLine("\n***** Recharge *****\n");

        System.Console.WriteLine("Enter the Amount To be Recharged");
        int amount = int.Parse(Console.ReadLine());
        user.Balance = user.Balance + amount;
        System.Console.WriteLine("Recharged Successfully!!! Your Current Balance is: "+user.Balance+"\n");
    }


    public static void DefaultDetails()
    {
        //Default User Details
        userList.Add(new UserDetails("Ravi" , 33 , "Theni" , 9877774440 , 400));
        userList.Add(new UserDetails("Baskaran" , 33 , "Chennai" , 8847757470 , 500));

        //Default Medicine Details
        medicineList.Add(new MedicineDetails("Paracitamo" , 40 , 5 , new DateTime(2022,06,30)));
        medicineList.Add(new MedicineDetails("Calpol" , 10 , 5 , new DateTime(2022,05,30)));
        medicineList.Add(new MedicineDetails("Gelucil" , 3 , 40 , new DateTime(2022,04,30)));
        medicineList.Add(new MedicineDetails("Metrogel" , 5 , 50 , new DateTime(2022,10,30)));
        medicineList.Add(new MedicineDetails("Povidin Iodin" , 10 , 50 , new DateTime(2022,10,30)));


        //Default Order Details
        orderList.Add(new OrderDetails("UID1001" , "MD101" , 3 , 15 , new DateTime(2022,05/13) , OrderStatus.Purchased));
        orderList.Add(new OrderDetails("UID1001" , "MD102" , 2 , 10 , new DateTime(2022,05/13) , OrderStatus.Cancelled));
        orderList.Add(new OrderDetails("UID1001" , "MD104" , 2 , 100 , new DateTime(2022,05/13) , OrderStatus.Purchased));
        orderList.Add(new OrderDetails("UID1002" , "MD103" , 3 , 120 , new DateTime(2022,05/15) , OrderStatus.Cancelled));
        orderList.Add(new OrderDetails("UID1002" , "MD105" , 5 , 250 , new DateTime(2022,05/15) , OrderStatus.Purchased));
        orderList.Add(new OrderDetails("UID1002" , "MD102" , 3 , 15 , new DateTime(2022,05/15) , OrderStatus.Purchased));
    }
}