using System;
namespace CafateriaCardManagement;
public class OrderDetails
{
    static int s_orderId= 1000;
    public string OrderId { get; set; }
    public string UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public int OrderPrice { get; set; }   

    public OrderDetails(string userId ,DateTime orderDate ,int orderPrice )   
    {
        s_orderId++;
        OrderId = "OID" + s_orderId;
        UserId = userId;
        OrderDate = orderDate ;
        OrderPrice = orderPrice ;
    }  
    
}