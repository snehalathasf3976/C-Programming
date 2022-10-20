namespace EBBillCalculation;
public class CustomerDetails
{
    public static int s_meterId = 1000 ;
    public string MeterId { get; set; }
    public string CustomerName { get; set; }
    public long MobileNumber { get; set; }
    public string MailId { get; set; }   
    public int UnitUsed{ get; set; }

    public CustomerDetails(string name , long mobileNumber , string mailId )
    {
        s_meterId++;
        MeterId = "EB" + s_meterId ;
        CustomerName = name ; 
        MobileNumber = mobileNumber ; 
        MailId = mailId ;
    }
    public int CalculateBill(int unit)
    {
        UnitUsed = UnitUsed + unit;
        int bill = unit*5;
        return bill;   
    }
}