Point a = new Point(2, 3);
Point b = new Point(-4, 0);

Console.WriteLine($"{a._x}, {a._y}");
Console.WriteLine($"{b._x}, {b._y}");

public class Point
{
    public float _x { get; }
    public float _y {get;}

    public Point(float x, float y)
    {
        _x = x;
        _y = y;
    }

    public Point() 
    {
        _x = 0;
        _y = 0;
    }

}
