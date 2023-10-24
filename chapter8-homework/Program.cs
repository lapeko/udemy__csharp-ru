
var c1 = new Complex(1, 2);
var c2 = new Complex(2, 3);

var res = c1.Plus(c2);
var res2 = res.Minus(new Complex(1, 1));

Console.WriteLine(res.Real);
Console.WriteLine(res.Imaginary);

Console.WriteLine(res2.Real);
Console.WriteLine(res2.Imaginary);

class Complex
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