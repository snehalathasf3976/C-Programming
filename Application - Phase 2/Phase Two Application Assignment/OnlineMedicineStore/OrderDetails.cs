using System;
/// <summary>
/// Used to Process the Order Details
/// </summary>
namespace OnlineMedicineStore;
/// <summary>
/// Declaring Enumeration Values
/// </summary>
public enum OrderStatus{Default , Purchased , Cancelled }
public class OrderDetails
{
    /// <summary>
    /// private orderId Field , Value Will be Auto increment Each Time
    /// </summary>
    static int s_orderID = 2000 ; 
    /// <summary>
    /// OrderId Property used to access the Private field
    /// </summary>
    /// <value></value>
    public string OrderId { get; set; }
    /// <summary>
    /// UserId of the Purchased User
    /// </summary>
    /// <value></value>
    public string UserId { get; set; }
    /// <summary>
    /// MedicineId of the Purchased Medicine
    /// </summary>
    /// <value></value>
    public string MedicineID { get; set; }
    /// <summary>
    /// Medicine Count of the Purchased Medicine
    /// </summary>
    /// <value></value>
    public int MedicineCount { get; set; }
    /// <summary>
    /// Total Price of the Purchased Medicine
    /// </summary>
    /// <value></value>
    public int TotalPrice { get; set; }
    /// <summary>
    /// OrderDate of the Purchased order
    /// </summary>
    /// <value></value>
    public DateTime OrderDate { get; set; }
    /// <summary>
    /// Order Date of the Purchased order
    /// </summary>
    /// <value></value>
    public OrderStatus OrderStatus { get; set; }

    /// <summary>
    /// OrderDetails Constructor to Assign the user Values to the Properties in the class
    /// </summary>
    /// <param name="userId"></param> userid Parameter value is Assigned to  UserId Property
    /// <param name="medicineId"></param> medicineId Parameter value is Assigned to Medicine Property
    /// <param name="medicineCount"></param> medicineCount Parameter value is Assigned to MedicineCount Property
    /// <param name="totalPrice"></param> totalPrice Parameter value is Assigned to TotalPrice Property
    /// <param name="orderDate"></param> orderDate Parameter value is Assigned to OrderDate Property
    /// <param name="orderStatus"></param> orderStatus Parameter value is Assigned to OrderStatus Property 
    public OrderDetails(string userId , string medicineId , int medicineCount , int totalPrice , DateTime orderDate , OrderStatus orderStatus)
    {
        s_orderID++;
        OrderId = "OID" + s_orderID ; 
        UserId = userId ;
        MedicineID = medicineId ;
        MedicineCount = medicineCount ;
        TotalPrice = totalPrice ;
        OrderDate = orderDate ;
        OrderStatus = orderStatus ;

    }
}