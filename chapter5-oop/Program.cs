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

// Boxing and unboxing
// double num = 1.1;
// object boxedNum = (object)num;
// // Console.WriteLine((int)boxedNum); // Unable to cast object of type 'System.Double' to type 'System.Int32'.
// Console.WriteLine((int)(double)boxedNum);

// IS and AS operators
// Point point = new Point();
// DoSomething(point);
//
// void DoSomething(object obj)
// {
//     var isPoint = obj is Point;
//     if (isPoint)
//     {
//         Console.WriteLine((obj as Point).x);
//         return;
//     }
//     else
//         Console.WriteLine("You should provide Point object");
//
//     var point = obj as Point;
//     if (point == null)
//     {
//         Console.WriteLine("You should provide Point object");
//         return;
//     }
//     Console.WriteLine(point.x);
// }
//
// class Point
// {
//     public int x;
//     public int y;
// }

var stack = new MyStack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
Console.WriteLine($"1: {stack.Peek()}"); // logs 5
Console.WriteLine($"2: {stack.Peek()}"); // logs 5
Console.WriteLine($"3: {stack.Pop()}"); // logs 5
Console.WriteLine($"4: {stack.Pop()}"); // logs 4
Console.WriteLine($"5: {stack.Peek()}"); // logs 3
stack.Push(4);
stack.Push(5);
Console.WriteLine($"6: {stack.Pop()}"); // logs 5
Console.WriteLine($"7: {stack.Pop()}"); // logs 4
stack.Pop(); // return 3
stack.Pop(); // return 2
Console.WriteLine($"8: {stack.Pop()}"); // logs 1
// Console.WriteLine($"9: {stack.Peek()}"); // Should throw an error as a stack is empty