using System;
using System.Collections.Generic;
namespace BloodBankManagement;
public class Donation
{
    static int s_donationId = 1000 ; 
    public string DonationId { get; set; }
    public string DonorId { get; set; }
    public DateTime DonationDate { get; set; }
    public int Weight { get; set; }
    public int BloodPressure { get; set; }
    public double Hemoglobin { get; set; }

    public Donation(string donorId , DateTime donationDate , int weight , int bloodPressure , double hemoglobin)
    {
        s_donationId++;
        DonationId = "DID" + s_donationId;
        DonorId =donorId ;
        DonationDate = donationDate ;
        Weight = weight ; 
        BloodPressure = bloodPressure ;
        Hemoglobin = hemoglobin;
    }
}