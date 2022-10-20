namespace CafateriaCardManagement;
public class OrderItems
{
    private static int s_orderId = 1000 ;
    public string OderId { get; set; }
    public string FoodId { get; set; }
    public string FoodName { get; set; }
    public int FoodPrice { get; set; }
    public int OrderCount { get; set; }  


    public OrderItems(string foodId , int orderCount , int price )
    {
        s_orderId++;
        OderId = "OID" + s_orderId;
        FoodId = foodId;
        FoodPrice = price ;
        OrderCount = orderCount ;
    }  
    
}