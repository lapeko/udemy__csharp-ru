namespace chapter8_homework;

public class Complex
{
    public double Real { get; private set; }
    public double Imaginary { get; private set; }
    
    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public Complex Plus(Complex arg)
    {
        return new Complex(Real + arg.Real, Imaginary + arg.Imaginary);
    }
    
    public Complex Minus(Complex arg)
    {
        return new Complex(Real - arg.Real, Imaginary - arg.Imaginary);
    }
}