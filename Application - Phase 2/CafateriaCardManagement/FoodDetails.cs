namespace CafateriaCardManagement;

public class FoodDetails
{
    private static int s_foodId = 100 ;
    public string FoodId { get; set; }
    public string FoodName { get; set; }
    public int FoodPrice { get; set; }
    public int AvailableQuality { get; set; }


    public  FoodDetails(string foodName , int foodPrice , int availableQuality)
    {
        s_foodId++;
        FoodId = "FID" + s_foodId;
        FoodName = foodName ;
        FoodPrice = foodPrice ; 
        AvailableQuality = availableQuality ;
    }
    
}
