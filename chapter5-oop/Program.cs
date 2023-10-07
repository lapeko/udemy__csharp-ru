using System.Threading.Channels;
using chapter5_oop;
using chapter5_oop.obj;

// Homework 1
// var res = RomeNumbers.ConvertToArabic("XIV");
// Console.WriteLine(res);

// Homework2
// Console.WriteLine(AreaCalculator.CalcForTriangle(3, 4, 5D));
// Console.WriteLine(AreaCalculator.CalcForTriangle(3, 4));
// Console.WriteLine(AreaCalculator.CalcForTriangle(3, 4, 90));

// TryDo
// TryDo.TryDivide(1, 2, out double result);
// Console.WriteLine(result);

// Rest (params)
// Console.WriteLine(SumNumbers(1, 2, 3, 4));
//
// int SumNumbers(params int[] nums)
// {
//     return nums.Aggregate((acc, num) => acc + num);
// }

// Optional params
// Console.WriteLine(CalculateTriangleArea(10, 10, 1.5, true));
//
// double CalculateTriangleArea(double a, double b, double angle, bool isInRadians = false)
// {
//     var radians = isInRadians ? angle : angle * Math.PI / 180;
//     return a * b * Math.Sin(radians) / 2;
// }

// Ref vs value types
// var pRef1 = new PointRef();
// var pRef2 = pRef1;
//
// Console.WriteLine(pRef1);
// Console.WriteLine(pRef2);
//
// pRef1.x = 10;
// pRef1.y = 11;
//
// Console.WriteLine(pRef1);
// Console.WriteLine(pRef2);
//
// Console.WriteLine("------------------------------");
//
// var pVal1 = new PointVal();
// var pVal2 = pVal1;
//
// Console.WriteLine(pVal1);
// Console.WriteLine(pVal2);
//
// pVal1.x = 10;
// pVal1.y = 11;
//
// Console.WriteLine(pVal1);
// Console.WriteLine(pVal2);
//
// class PointRef
// {
//     public int x;
//     public int y;
//
//     public override string ToString()
//     {
//         return $"x: {x}, y: {y}";
//     }
// }
//
// struct PointVal
// {
//     public int x;
//     public int y;
//     
//     public override string ToString()
//     {
//         return $"x: {x}, y: {y}";
//     }
// }

// pass primitives by ref
// int x = 1, y = 2;
// Swap(ref x, ref y);
// Console.WriteLine($"x: {x}, y: {y}");
//
// void Swap(ref int num1, ref int num2)
// {
//     (num2, num1) = (num1, num2);
// }

// Nullable
// Car? car = CallToDbForCar(); 
//
// Car? CallToDbForCar()
// {
//     return null;
// }
//
// struct Car
// {
//     public string Color;
//     public int MaxSpeed;
//
//     public Car(string color, int maxSpeed)
//     {
//         Color = color;
//         MaxSpeed = maxSpeed;
//     }
// }
