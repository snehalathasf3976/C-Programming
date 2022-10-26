namespace CalculatorApp;
public class CynlinderVolume : CircleArea
{
    private static int s_height;
    public int Height { get; set; }
    internal int Volume { get; set; }

    public CynlinderVolume(int height , double radius ):base(radius)
    {
        Height = height ;
    }


    public void CalculateVolume()
    {
        double volume = CalculateCircleArea() * Height ;
        System.Console.WriteLine("Volume is: "+volume);
    }
}