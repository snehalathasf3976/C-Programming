using System;
namespace OnlineMedicineStore;
/// <summary>
/// Used to Process the Medicine Details
/// </summary>
public class MedicineDetails
{
    /// <summary>
    ///  private MedicineId Field , Value Will be Auto increment Each Time
    /// </summary>
    static int s_medicineId = 100 ; 
    /// <summary>
    /// MedicineId Property used to access the Private field
    /// </summary>
    /// <value></value>
    public string MedicineId { get; set; }
    /// <summary>
    /// Property for the Medicine Name
    /// </summary>
    /// <value></value>
    public string MedicineName { get; set; }
    /// <summary>
    /// Property for Available Count of the Medicine
    /// </summary>
    /// <value></value>
    public int AvailableCount { get; set; }
    /// <summary>
    /// Property for Price of the Medicine
    /// </summary>
    /// <value></value>
    public int Price { get; set; }
    /// <summary>
    /// Property for Expiry Date of the Medicine
    /// </summary>
    /// <value></value>
    public DateTime DateofExpiry { get; set; }

    /// <summary>
    /// MedicineDetails Constructor to Assign the user Values to the Properties in the class
    /// </summary>
    /// <param name="medicineName"></param> medicine Name Parameter value is Assigned to the Medicine Name Property
    /// <param name="availableCount"></param> available count Parameter value is Assigned to Available Count Property
    /// <param name="price"></param> price Parameter value is Assigned to Price Property
    /// <param name="dateOfExpiry"></param> dateofExpiry Parameter value is Assigned to DateOfExpiry Property
    public MedicineDetails(string medicineName , int availableCount , int price , DateTime dateOfExpiry )
    {
        s_medicineId++;
        MedicineId = "MD" + s_medicineId;
        MedicineName = medicineName ;
        AvailableCount = availableCount ;
        Price = price ;
        DateofExpiry = dateOfExpiry ;
    }
}