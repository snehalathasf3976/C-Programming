namespace ECommerce;
public class ProductDetails
{
    static int s_productId = 100;
    public string ProductId { get; set; }
    public string ProductName { get; set; }
    public int ProductPrice { get; set; }
    public int ProductQuantity { get; set; }
    public int ShippingDuration { get; set; }

    public ProductDetails(string name , int productQuantity ,int productPrice ,  int shippingDuration )
    {
        s_productId++;
        ProductId = "PID" + s_productId;
        ProductName = name ;
        ProductPrice = productPrice ; 
        ProductQuantity = productQuantity ; 
        ShippingDuration = shippingDuration ;
    }
    public static int CalculatePrice(ProductDetails product,int quantity)
    {
        int price = (quantity * product.ProductPrice) + 50 ;
        return price;
    }
}