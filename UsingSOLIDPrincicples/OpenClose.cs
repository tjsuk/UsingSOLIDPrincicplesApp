namespace UsingSOLIDPrincicples;

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public override double CalculateArea()
    {
        double radius = 1;
        // Calculate logic for a circle
        return (Math.PI * radius * radius);
    }
}

public class Square : Shape
{
    public override double CalculateArea()
    {
        double length = 1;
        // Calculate logic for a square
        return length * length;
    }
}