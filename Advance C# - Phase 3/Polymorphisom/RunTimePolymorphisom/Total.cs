namespace RunTimePolymorphisom;
public class Total:Sports
{
    public int AcadamicMark = 80;
    public override void Display()
    {
        TotalMark = AcadamicMark + SportsMark ;
        System.Console.WriteLine("Total Mark is: "+TotalMark);
    }
}