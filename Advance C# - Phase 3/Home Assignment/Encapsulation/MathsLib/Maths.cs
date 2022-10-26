namespace MathsLib;
public class Maths
{
    protected internal double s_pi = 3.14 ;
    internal double s_g = 9.8;

    public void CalculateWeight(int weight)
    {
        double userWeight = weight * s_g;
    }
}