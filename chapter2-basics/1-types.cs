using System.Text;

RunHomeWork3();

void RunHomeWork3()
{
    Console.WriteLine("Enter your last name:");
    var lastName = Console.ReadLine();
    
    Console.WriteLine("Enter your first name:");
    var firstName = Console.ReadLine();
    
    Console.WriteLine("Enter your age:");
    var input = Console.ReadLine();
    if (input == null) return;
    var age = int.Parse(input);
    
    Console.WriteLine("Enter your weight:");
    input = Console.ReadLine();
    if (input == null) return;
    var weight = double.Parse(input);
    
    Console.WriteLine("Enter your height:");
    input = Console.ReadLine();
    if (input == null) return;
    var height = double.Parse(input);

    var bodyMassIndex = weight / (height * height / 10000);

    Console.Clear();

    var sb = new StringBuilder();
    sb
        .AppendLine("Your profile:")
        .AppendLine($"Full Name: {lastName}, {firstName}")
        .AppendLine($"Age: {age}")
        .AppendLine($"Weight: {weight}")
        .AppendLine($"Height: {height}")
        .AppendLine($"Body Mass Index: {bodyMassIndex:F}");
    Console.WriteLine(sb.ToString());
}

void RunHomeWork2()
{
    Console.WriteLine("Enter first side size of rectangle");
    var input = Console.ReadLine();
    if (input == null) return;
    var side1 = double.Parse(input);
    
    Console.WriteLine("Enter second side size of rectangle");
    input = Console.ReadLine();
    if (input == null) return;
    var side2 = double.Parse(input);
    
    Console.WriteLine("Enter third side size of rectangle");
    input = Console.ReadLine();
    if (input == null) return;
    var side3 = double.Parse(input);

    var halfPerimeter = (side1 + side2 + side3) / 2;
    var triangleArea = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3)); 
    Console.WriteLine($"Area of the rect is: {triangleArea:F}");
}

void RunHomeWork1()
{
    Console.WriteLine("Enter your name");
    var name = Console.ReadLine();
    Console.WriteLine($"Hello {name}. Press Enter to continue");

    int num1;
    int num2;

    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Enter num1");
    string? input = Console.ReadLine();
    if (input == null)
    {
        Console.WriteLine("You entered incorrect value");
        return;
    }
    num1 = int.Parse(input);
    
    Console.Clear();
    Console.WriteLine("Enter num2");
    input = Console.ReadLine();
    if (input == null)
    {
        Console.WriteLine("You entered incorrect value");
        return;
    }
    num2 = int.Parse(input);
    
    Console.Clear();
    Console.WriteLine($"You entered num1: {num1}, num2: {num2}");
    num1 = num2 - num1;
    num2 -= num1;
    num1 += num2;
    Console.WriteLine($"After swapping: num1: {num1}, num2: {num2}");
    Console.WriteLine("Press enter to continue");

    Console.ReadLine();
    
    Console.Clear();

    Console.WriteLine("Enter a number");
    input = Console.ReadLine();
    if (input == null)
    {
        Console.WriteLine("You entered incorrect value");
        return;
    }
    num1 = int.Parse(input);
    Console.WriteLine($"Size of your number {num1} is: {num1.ToString().Length}");
}

void RunCasting()
{   
    byte bNum = 3;
    int intNum = bNum;
    long lNum = intNum;
    bNum = (byte)lNum;

    Console.WriteLine((double)bNum / 2);
}

void RunWorkWithInput()
{
    Console.WriteLine("Inter your name:");
    var name = Console.ReadLine();
    Console.Clear();
    
    Console.WriteLine("PLease tell your age:");
    var input = Console.ReadLine();
    if (input == null)
    {
        Console.WriteLine("Please provide your age");
        return;
    }
    Console.Clear();
    
    var age = int.Parse(input);
    Console.WriteLine($"Your name is: {name}");
    Console.WriteLine($"Your age is: {age}");
}

void RunStringBuilderAndFormat()
{
    var sb = new StringBuilder();

    sb.AppendLine("Hi there!");
    sb.AppendLine("My name is Vitali!");

    Console.WriteLine(sb.ToString());

    const string name = "Vitali";
    const int age = 35;
    Console.WriteLine(string.Format("Hi there! My name is {0}. I'm {1}", name, age));
    Console.WriteLine($"Hi there! My name is {name}. I'm {age}");

    const int answer = 42;
    Console.WriteLine($"{answer:d}");
    Console.WriteLine($"{answer:d4}");
    
    Console.WriteLine($"{answer:f1}");
    Console.WriteLine($"{answer:f4}");
    
    const double money = 12.3;
    Console.WriteLine($"{money:C}");
    Console.WriteLine($"{money:C2}");
}

void RunStrings()
{
    const string word = "abracadabra";
    var containsA = word.Contains('a');

    Console.WriteLine(containsA);

    var endsWithAbra = word.EndsWith("abra");
    Console.WriteLine(endsWithAbra);
    
    var startWithAbra = word.StartsWith("abraca");
    Console.WriteLine(startWithAbra);

    var indexOfD = word.IndexOf('d');
    Console.WriteLine(indexOfD);

    const string space = " ";
    var isNullOrEmpty = string.IsNullOrEmpty(space);
    Console.WriteLine("isNullOrEmpty: " + isNullOrEmpty);
    
    var isEmptyOrSpace = string.IsNullOrWhiteSpace(space);
    Console.WriteLine("isEmptyOrSpace: " + isEmptyOrSpace);

    Console.WriteLine(string.Empty == "");

    Console.WriteLine(string.Concat("My ", "name ", "is ", "Vitali"));
    var myNameString = string.Join(" ", "My", "name", "is", "Vitali");
    Console.WriteLine(myNameString);

    Console.WriteLine(myNameString.Insert(0, "Hi there! "));


}

void RunOverflow()
{
    int max = int.MaxValue;

    checked
    {
        Console.WriteLine(max);
        Console.WriteLine(++max);
        Console.WriteLine(--max);   
    }
}

void RunLiterals()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;

    int x2 = 0b11;
    int y2 = 0b1001_1001;
    
    Console.WriteLine("x2: " + x2);
    Console.WriteLine("y2: " + y2);

    int x16 = 0xFF;
    
    Console.WriteLine("x16: " + x16);

    Console.WriteLine(3.1e+2);
    Console.WriteLine(2e-3);

    Console.WriteLine('\x78');
    Console.WriteLine('\u0420');
}

void RunVariables()
{
    int x = -1;

    int y;
    y = 1;

    // Int32 x1 = -1;
    // uint x2 = 32;

    float f = 1.1F;

    // next two lines are equivalent
    int x5 = 0;
    int x6 = new int();

    // int this case - int a = 1 will be the same
    var a = 1;

    // using var there can be convenient
    Dictionary<int, string> dict = new Dictionary<int, string>();
    var dict2 = new Dictionary<int, string>();

    decimal dc = 3.1m;

    char character = 'a';
    string name = "Vitali";

    bool canDrive = true;

    object obj = 1;
    object obj2 = "123";
    object @object = 'c';
}
