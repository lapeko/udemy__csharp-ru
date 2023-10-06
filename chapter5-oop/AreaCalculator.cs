namespace chapter5_oop;

class AreaCalculator
{
    public static double CalcForTriangle(double side1, double side2, double side3)
    {
        var halfPerimeter = (side1 + side2 + side3) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
    }
    
    public static double CalcForTriangle(double basement, double height)
    {
        return basement * height / 2;
    }
    
    public static double CalcForTriangle(double side1, double side2, int angle)
    {
        var radians = angle * Math.PI / 180;
        return side1 * side2 * Math.Sin(radians) / 2;
    }
}