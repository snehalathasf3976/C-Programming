using System;
using MathsLib;
namespace CalculatorApp;
class Program
{
    public static void Main(string[] args)
    {
        CynlinderVolume volume = new CynlinderVolume(6 , 2.3);
        volume.CalculateVolume();
        
    }
}