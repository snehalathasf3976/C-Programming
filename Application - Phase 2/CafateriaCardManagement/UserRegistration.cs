using System;
using System.Collections.Generic;
namespace CafateriaCardManagement;
public static class UserRegistration
{
    public static List<UserDetails> userList = new List<UserDetails>();
    public static List<FoodDetails> foodList = new List<FoodDetails>();
    public static List<OrderDetails> orderList = new List<OrderDetails>();
    public static void MainMenu()
    {
        string condition = "YES";
        do
        {
            System.Console.WriteLine("Select the Option to Perform \n1.User Registration \n2.User Login \n3.Exit");
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
            }
                
        } while (condition == "YES");
    }
    public static void Registration()
    {
        System.Console.WriteLine("Enter the name");
        string userName = Console.ReadLine();

        System.Console.WriteLine("Enter the Mobile Number");
        long mobileNumber = long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Work Station Number");
        string workStationNumber = Console.ReadLine();

        System.Console.WriteLine("Enter the Balance");
        int balance =int.Parse(Console.ReadLine());

        UserDetails user = new UserDetails(userName , mobileNumber , workStationNumber , balance );
        System.Console.WriteLine("Registration Successful , Your Registration Id is : "+user.UserId);
        userList.Add(user);
            
    }
    public static void Login()
    {
        int price , totalAmount;
        System.Console.WriteLine("Enter the User Id");
        string userId = Console.ReadLine();
        foreach(UserDetails user in userList)
        {
            if(user.UserId == userId)
            {
                string condition = "YES";
                DisplayFoodDetails();
                do
                {
                    System.Console.WriteLine("|-----------------------------------------------|");
                    System.Console.WriteLine("|Food ID | Food Name | Price | Availabe Quantity|");
                    System.Console.WriteLine("|-----------------------------------------------|");
                    foreach (FoodDetails foodDetails in foodList)
                    {
                        System.Console.WriteLine($"|{foodDetails.FoodId , -7} | {foodDetails.FoodName, -9} | {foodDetails.FoodPrice, -5} | {foodDetails.AvailableQuality, -17}|");
                        System.Console.WriteLine("|-----------------------------------------------|");
                    }
                    System.Console.WriteLine("Enter the Food Id");
                    string foodId = Console.ReadLine();
                    System.Console.WriteLine("Enter the Quantity Required");
                    int foodQuantity = int.Parse(Console.ReadLine());
                    price = CalculatePrice(foodId , foodQuantity);
                    OrderItems food = new OrderItems(foodId , foodQuantity , price );
                    orderList.Add(food);
                    System.Console.WriteLine("Do You Wanna Select Another");
                    condition = Console.ReadLine().ToUpper();

                }while(condition == "YES");
                totalAmount = TotalAmount();
                if(totalAmount < user.Balance)
                {
                    SubMenu();
                }
                else
                {
                    user.Balance = user.Balance - totalAmount;
                }
            }
            if(user.UserId != userId)
            {
                System.Console.WriteLine("Invalid User");
            }
        }
    }
    public static void DisplayFoodDetails()
    {
        foodList.Add(new FoodDetails("Coffee" , 20 , 1000));
        foodList.Add(new FoodDetails("Tae" , 15 , 1000));
        foodList.Add(new FoodDetails("Bissuit" , 10 , 1000));
        foodList.Add(new FoodDetails("Juice" , 50 , 1000));
        foodList.Add(new FoodDetails("Puff" , 40 , 1000));

        userList.Add(new UserDetails("Ravi" , 9747834896 , "WS101" , 400));
        userList.Add(new UserDetails("Ravi" , 9747834896 , "WS101" , 400));


        orderList.Add(new OrderDetails("SF1001" ,new DateTime(2022/06/05) , 70 ));
        orderList.Add(new OrderDetails("SF1001" ,new DateTime(2022/06/05) , 70 ));

    }
    public static int CalculatePrice(string foodId , int foodQuantity)
    {
        int price = 1;
        foreach(FoodDetails food in foodList)
        {
            if(foodId == food.FoodId)
            {
              price = foodQuantity*food.FoodPrice;  
            }
        }
        return price;
    }
    public static int TotalAmount()
    {
        int totalAmount = 0;
        foreach(OrderItems order in orderList)
        {
            System.Console.WriteLine(order.FoodName);
            totalAmount = totalAmount + order.FoodPrice;
        }
        return totalAmount;
    }
}