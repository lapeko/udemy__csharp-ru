
using System.Threading.Channels;

RunStrings();

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
