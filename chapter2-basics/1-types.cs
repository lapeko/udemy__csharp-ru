
RunLiterals();

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
