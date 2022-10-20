using System;
namespace ECommerce;
public enum OrderStatus { Default , Ordered , Cancel }
public class OrderDetails
{
    public static int s_orderId = 100 ;
    public string OrderID { get; set; }
    public string CustomerID { get; set; }
    public string ProductID { get; set; }
    public int TotalPrice { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int Quantity { get; set; }
    public OrderStatus OrderStatus { get; set; }

    public OrderDetails(string customerId , string productId , int totalPrice , DateTime purchaseDate , int quantity , OrderStatus orderStatus)
    {
        s_orderId++;
        OrderID = "OID" + s_orderId;
        CustomerID = customerId;
        ProductID = productId ;
        TotalPrice = totalPrice;
        PurchaseDate = purchaseDate;
        Quantity = quantity;
        OrderStatus = orderStatus;
    }
}