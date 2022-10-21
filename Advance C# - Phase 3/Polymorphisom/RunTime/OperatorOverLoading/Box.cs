namespace OperatorOverLoading;
public class Box
{
    private double _length { get; set; }
    private double _breadth { get; set; }
    private double _height { get; set; }

    public Box()
    {

    }

    public Box(double length , double breadth , double height )
    {
        _length = length;
        _breadth = breadth ;
        _height = height ;
    }

    public double CalculateVolume()
    {
        return _length * _breadth * _height ;
    }

    public static Box operator + (Box box1 , Box box2) //Overload + Operator to Add two Object
    {
        Box box3 = new Box();
        box3._length = box1._length + box2._length ;
        box3._breadth = box1._breadth + box2._breadth ;
        box3._height = box1._height + box2._height ;
        return box3;
    }

    public Box Add(Box box1 , Box box2) //Adding Object By using Method
    {
        Box box3 = new Box();
        box3._length = box1._length + box2._length ;
        box3._breadth = box1._breadth + box2._breadth ;
        box3._height = box1._height + box2._height ;
        return box3;
    }
}