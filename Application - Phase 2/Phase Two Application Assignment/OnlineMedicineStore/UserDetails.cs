namespace OnlineMedicineStore;
/// <summary>
/// Used to Process the User Details
/// </summary>
public class UserDetails
{
    /// <summary>
    /// private userId Field , Value Will be Auto increment Each Time
    /// </summary>
    static int s_userId = 1000;
    /// <summary>
    /// UserId Property used to access the Private field
    /// </summary>
    /// <value></value>
    public string UserId { get; set; }
    /// <summary>
    /// Property to store the User Name
    /// </summary>
    /// <value></value>
    public string UserName { get; set; }
    /// <summary>
    /// Property to Store the Age of the user
    /// </summary>
    /// <value></value>
    public int Age { get; set; }
    /// <summary>
    /// Property to Store the City name of the User
    /// </summary>
    /// <value></value>
    public string City { get; set; }
    /// <summary>
    /// Property to store the Mobile Number of the User 
    /// </summary>
    /// <value></value>
    public long MobileNumber { get; set; }
    /// <summary>
    /// Property to store the Balance Amount of the User
    /// </summary>
    /// <value></value>
    public int Balance { get; set; }
    /// <summary>
    /// UserDetails Constructor to Assign the user Values to the Properties in the class
    /// </summary>
    /// <param name="userName"></param> userName Parameter value is Assigned to UserName Property
    /// <param name="age"></param> age Parameter value is Assigned to to Age Property
    /// <param name="city"></param> city Parameter value is Assigned to City Property
    /// <param name="mobileNumber"></param> mobileNumber Parameter value is Assigned to MobileNumber Property
    /// <param name="balance"></param> balance Parameter value is Assigned to BAlance Property
    public UserDetails(string userName , int age , string city , long mobileNumber , int balance)
    {
        s_userId++;
        UserId = "UID" + s_userId;
        UserName = userName ;
        Age = age ;
        City = city;
        MobileNumber = mobileNumber ;
        Balance = balance ;

    }
}