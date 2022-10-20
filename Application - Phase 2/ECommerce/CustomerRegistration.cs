using System;
using System.Collections.Generic;
namespace ECommerce;
public class CustomerRegistration
{
    static List<CustomerDetails> customerList = new List<CustomerDetails>();
    static List<ProductDetails> productList = new List<ProductDetails>();
    static List<OrderDetails> orderList = new List<OrderDetails>();
    public static void MainMenu()
    {
        string condition = "YES";
        do
        {
            System.Console.WriteLine("Enter the Operation to Do \n1.Registration \n2.Login And Purchase \n3.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Registration();
                    System.Console.WriteLine("Do You Wanna Continue");
                    condition = Console.ReadLine().ToUpper();
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
        }while(condition == "YES");
    }
    public static void Registration()
    {

        System.Console.WriteLine("Enter the Name");
        string customerName = Console.ReadLine();

        System.Console.WriteLine("Enter Your City");
        string city = Console.ReadLine();
        
        System.Console.WriteLine("Enter Your Mobil Number: ");
        long mobileNumber = long.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Your Mail ID");
        string mailId = Console.ReadLine();

        System.Console.WriteLine("Enter The Wallet Initial Balance: ");
        int initialBalance = int.Parse(Console.ReadLine());

        CustomerDetails customer = new CustomerDetails(customerName , city , mobileNumber , mailId  , initialBalance );
        System.Console.WriteLine("Your Employee Id is: "+customer.CustomerId);
        customerList.Add(customer);
    }
    public static void Login()
    {
        System.Console.WriteLine("Enter the Customer Id");
        string customerId = Console.ReadLine().ToUpper();
        int count = 0;
        foreach(CustomerDetails customer in customerList)
        {
            if(customer.CustomerId == customerId)
            {
                count = 1;
                SubMenu(customer);
            }
        }
        if(count == 0)
        {
            System.Console.WriteLine("Invalid User");
        }
    }
    static void SubMenu(CustomerDetails customer)
    {
        string condition = "YES";
        do
        {
            System.Console.WriteLine("Enter the Operation to do \n1.Purchase \n2.Order History \n3.Cancel Order \n4.Wallet Balance \n5.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    DisplayDefaultProduct();
                    SelectProduct(customer);
                    break;
                }
                case 2:
                {     
                    OrderHistory(customer);           
                    break;
                }
                case 3:
                {
                    CancelOrder(customer);
                    break;
                }
                case 4:
                {
                    WalletBalance(customer);
                    break;
                }
                case 5:
                {
                    condition = "no";
                    break;
                }
            }
        }while(condition == "YES");
    }
    static void WalletBalance(CustomerDetails customer)
    {
        System.Console.WriteLine("Your Balane is: "+customer.WalletInitialBalance);
        System.Console.WriteLine("Do You Wanna Recharge Your Wallet (Yes/No)");
        string temp = Console.ReadLine().ToUpper();
        if(temp == "YES")
        {
            System.Console.WriteLine("Enter the Amount to Be Added in Your Wallet: ");
            int Balance = int.Parse(Console.ReadLine());
            customer.WalletInitialBalance = customer.WalletInitialBalance + Balance ;
            System.Console.WriteLine("Your Updated Balance is: "+customer.WalletInitialBalance);
        }
    }
    static void CancelOrder(CustomerDetails customer)
    {
        OrderHistory(customer);
        System.Console.WriteLine("Enter the Order Id to Cancel the Order");
        string orderId = Console.ReadLine().ToUpper();
        int flag = 0;
        foreach(OrderDetails order in orderList)
        {
            if(order.OrderID == orderId)
            {
                order.OrderStatus = OrderStatus.Cancel;
                foreach(ProductDetails product in productList)
                {
                    if(order.ProductID == product.ProductId)
                    {
                        flag = 1;
                        product.ProductQuantity = product.ProductQuantity + order.Quantity ;
                        System.Console.WriteLine("Order Cancelled Successfully");
                        customer.WalletInitialBalance = customer.WalletInitialBalance + order.TotalPrice;
                        System.Console.WriteLine("Order Amount Added To Your Wallet");
                    }
                }
            }
        }
        if(flag == 0)
        {
            System.Console.WriteLine("Invalid Id Enter the Proper ID");
        }
    }
    static void OrderHistory(CustomerDetails customer)
    {
        System.Console.WriteLine("|Order Id | Customer ID | Product Id |  Price  | Purchased Date | Quantity | Order Status | ");
        foreach(OrderDetails order in orderList)
        {
            if(order.CustomerID == customer.CustomerId)
            {
                System.Console.WriteLine($"| {order.OrderID, -7} | {order.CustomerID , -11} | {order.ProductID , -10} | {order.TotalPrice ,-7} | {order.PurchaseDate.ToString("dd/MM/yyyy"), -14} |{order.Quantity , -9} | {order.OrderStatus ,-12} |");
            }
        }
    }
    public static void DefaultProduct()
    {
        productList.Add(new ProductDetails("Mobile" , 10 ,10000 , 3 ));
        productList.Add(new ProductDetails("Tablet" , 5 ,15000 ,2 ));
        productList.Add(new ProductDetails("Camera" , 3 ,20000 , 4 ));
        productList.Add(new ProductDetails( "Iphone" , 5 ,50000 , 6 ));
        productList.Add(new ProductDetails( "Laptop" ,  3 , 40000 , 3 ));

        customerList.Add(new CustomerDetails("Ravi" , "Chennai" , 98789865442 , "ravi@gmail.com" , 50000));
        customerList.Add(new CustomerDetails("Baskaran" , "Chennai" , 9654788323 , "baskaran@gmail.com" , 60000));

        orderList.Add(new OrderDetails("CID1001" , "PID101" , 20000 , DateTime.Now , 2 , OrderStatus.Ordered));
        orderList.Add(new OrderDetails("CID1002" , "PID103" , 40000 , DateTime.Now , 2 , OrderStatus.Ordered));
    }
    static void DisplayDefaultProduct()
    {
        System.Console.WriteLine("| Product Id | Product Name | Product Quantity | Product Price | Shipping Duration |");
        foreach (ProductDetails product in productList)
        {
            System.Console.WriteLine($"| {product.ProductId,-10} | {product.ProductName,-12} | {product.ProductQuantity,-16} | {product.ProductPrice, -13} | {product.ShippingDuration, -17} | ");  
        }
    }
    static void SelectProduct(CustomerDetails customer)
    {
        System.Console.WriteLine("Select the Product by Product Id");
        string productId = Console.ReadLine().ToUpper();
        System.Console.WriteLine("Enter the Count You Wish to Purchase");
        int productQuantity = int.Parse(Console.ReadLine());
        int count = 0;
        foreach(ProductDetails product in productList)
        {
            if(productId == product.ProductId)
            {
                count = 1;
                System.Console.WriteLine("Product in List");
                if(product.ProductQuantity > productQuantity)
                {
                    int price = ProductDetails.CalculatePrice(product , productQuantity);
                    System.Console.WriteLine("Total Price is: "+price);
                    if(customer.WalletInitialBalance < price)
                    {
                        System.Console.WriteLine("Insufficient Wallet Balance!! Please Recharge the Balance");
                    }
                    else
                    {
                        OrderDetails order = new OrderDetails(customer.CustomerId , product.ProductId , price , DateTime.Now , count , OrderStatus.Ordered);
                        orderList.Add(order);
                        customer.WalletInitialBalance = customer.WalletInitialBalance - price ;
                        System.Console.WriteLine("Your Wallet Amount is: "+customer.WalletInitialBalance);
                        DateTime Duration = order.PurchaseDate.AddDays(product.ShippingDuration);
                        System.Console.WriteLine("Order Successfull!!! Your Order Id is {0} \nDelivery Date of the Product is: {1}",order.OrderID ,Duration );
                    }
                }
                else
                {
                    System.Console.WriteLine("Product Count is Not Available!!!\n Cuurent Stock is :"+product.ProductQuantity);
                }
            }
        }
        if(count == 0)
        {
            System.Console.WriteLine("Product Not Available in the List");
        }
    }

        
}
