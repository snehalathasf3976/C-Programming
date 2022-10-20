namespace ECommerce;
public class CustomerDetails
{
    public static int s_customerId = 1000 ;
    public string CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerCity { get; set; }
    public long MobileNumber { get; set; }
    public string MailId { get; set; }   
    public int WalletInitialBalance{ get; set; }

    public CustomerDetails(string name ,string city , long mobileNumber , string mailId, int walletInitialBalance )
    {
        s_customerId++;
        CustomerId = "CID" + s_customerId ;
        CustomerName = name ; 
        CustomerCity = city ;
        MobileNumber = mobileNumber ; 
        MailId = mailId ;
        WalletInitialBalance = walletInitialBalance;
    }
}