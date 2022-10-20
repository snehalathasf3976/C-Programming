namespace LibraryManagement;
public enum Gender {Default , Male , Female , TransGender}
public enum Department {Default , ECE , EEE , CSE}
public class UserDetails
{
    static int s_userId = 3000;
    public string UserId { get; set; }
    public string UserName { get; set; }
    public Gender Gender { get; set; }
    public Department Department { get; set; }
    public long MobileNumber { get; set; }
    public string MailId { get; set; }


    public UserDetails(string userName , Gender gender , Department department , long mobileNumber , string mailId)
    {
        s_userId++;
        UserId = "SF" + s_userId;
        UserName = userName;
        Gender = gender ;
        Department = department ;
        MobileNumber = mobileNumber;
        MailId = mailId;

    }

}