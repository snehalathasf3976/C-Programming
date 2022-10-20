using System.Collections.Generic;
namespace CafateriaCardManagement
{
    public class UserDetails
    {
        static List<UserDetails> userDetailsList = new List<UserDetails>();
        private static int s_userId = 1000 ;
        public string UserId { get; set; }
        public string UserName { get; set; }
        public long MobileNumber { get; set; }
        public string WorkStationNumber { get; set; }
        public int Balance { get; set; }

        //Constructor
        public UserDetails(string userName , long mobileNumber , string workStationNumber , int balance )
        {
            s_userId++;
            UserId = "SF" + s_userId ;
            UserName = userName ;
            MobileNumber = mobileNumber;
            WorkStationNumber = workStationNumber ; 
            Balance = balance ;
        }
        

    }
}