namespace RunTimePolymorphisom;
public class Sports:Student
{
    public int SportsMark = 50 ;
    public override void Display()
    {
        System.Console.WriteLine("Name is: "+Name+"SportsMark is: "+SportsMark);
    }
}