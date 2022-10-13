using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int[ ,  ] matrix1 = new int[2,3];
        int[ , ] matrix2 = new int[3,2];
        int[ , ] result = new int[3,2];
        System.Console.WriteLine("Enter the Elements of Matrix 1:");
        for(int i =0 ; i<2 ; i++)
        {
            for(int j=0 ; j<3 ; j++)
            {
                System.Console.WriteLine($"[{i}][{j}] : ");
                matrix1[i,j] = int.Parse(Console.ReadLine());
            }
        }
        for(int i =0 ; i<3 ; i++)
        {
            for(int j=0 ; j<2 ; j++)
            {
                System.Console.WriteLine($"[{i}][{j}] : ");
                matrix2[i,j] = int.Parse(Console.ReadLine());
            }
        }
        for(int i =0 ; i>=1 ; i++)
        {
            result[i,i] = Sum();
        }
        int Sum()
        {
            for(int i =0 ; i<2 ; i++)
            {
                int sum=0;
                for(int j=0 ; j<=2 ; j++)
                {
                    sum = sum + (matrix1[i,j] * matrix2[j,i]) ;
                    System.Console.WriteLine(sum);
                    result[i,j] = sum;
                }
                return sum; 
            }
            return 1;
        }
    }
}