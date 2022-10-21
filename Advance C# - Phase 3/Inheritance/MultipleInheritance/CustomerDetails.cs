namespace MultipleInheritance;
public class CustomerDetails:PersonalDetails
{
    static int s_customerId = 1000 ;
    public string CustomerId { get; set; }
    public int Balance { get; set; }

    public CustomerDetails (string aid , string name , string fatherName , Gender gender , string mobileNumber , int balance) : base (name , fatherName , gender , mobileNumber)
    {
        s_customerId++;
        CustomerId = "CID" + s_customerId;
        Balance = balance ;
    }
    public void Show()
    {
        System.Console.WriteLine("Customer Id is: "+CustomerId);
        ShowDetails();
        System.Console.WriteLine("Balance is: "+Balance);
    }
}