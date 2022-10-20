namespace BloodBankManagement;
public enum BloodGroup{ Default , A_Postive , B_Positive , O_Positive , AB_Positive}
public class UserRegistration
{
    static int s_donorId = 1000;
    public string DonorId { get; set; }
    public string DonorName { get; set; }
    public long MobileNumber { get; set; }
    public BloodGroup DonorBloodGroup { get; set; }
    public int Age { get; set; }
    public string NativePlace { get; set; }

    public UserRegistration(string name , long mobileNumber , BloodGroup bloodGroup , int age , string native)
    {
        s_donorId++;
        DonorId = "UID" + s_donorId ;
        DonorName = name ;
        MobileNumber = mobileNumber;
        DonorBloodGroup = bloodGroup ;
        Age = age;
        NativePlace = native ;
    }
}