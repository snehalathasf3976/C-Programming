namespace BankApplication;
public enum Gender { Default , Male , Female ,Transgender}
public enum AccountType {RD , FD , SA}

public class BankDetails
{
    private static int s_customerId = 10000 ;
    public string CustomerId { get; set; }
    public string Name{get ; set; }
    public string FatherName{get; set;}
    public Gender Gender{get ; set ;}
    public AccountType AccountType{ get ; set ;}
    public int Balance { get; set; }

    public BankDetails(string name , string fatherName , Gender gender, AccountType accountType)
    {
        s_customerId++;
        CustomerId = "CA" + s_customerId ; 
        Name = name ;
        FatherName = fatherName ; 
        Gender = gender ;
        AccountType = accountType ;
    }

    public int ShowBalance()
    {
        return Balance;
    }

    public int Deposit(int depositAmount)
    {
        Balance = Balance + depositAmount ;
        return Balance;
    }
    public int Withdraw(int withdrawAmount)
    {
        if(Balance > withdrawAmount)
        {
            Balance = Balance - withdrawAmount ;
            return Balance;
        }
        else
        {
            return 0;
        }
    }
}