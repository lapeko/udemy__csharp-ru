RunFactorial();

void RunFactorial()
{
    Console.WriteLine("Enter size of factorial:");
    var input = Console.ReadLine();
    if (input == null) return;
    var size = uint.Parse(input);

    ulong factorial = 1;
    for (var i = size; i > 0; i--)
        factorial *= i;
    Console.WriteLine($"Factorial is: {factorial}");
}

void RunAverageOf10()
{
    var size = 0;
    var userNumbers = new int[10];

    do
    {
        Console.WriteLine($"Enter positive number{size + 1}:");
        var input = Console.ReadLine();
        if (input == null) return;
        var newNumber = int.Parse(input);
        if (newNumber < 0) continue;
        if (newNumber == 0) break;
        userNumbers[size++] = newNumber;
    } while (size < 10);

    Console.WriteLine("You entered:");
    for (var i = 0; i < size; i++)
        Console.WriteLine($"{i + 1}: {userNumbers[i]}");

    double sum = 0;
    var count = 0;
    for (var i = 0; i < size; i++)
    {
        if (userNumbers[i] % 3 != 0) continue;
        sum += userNumbers[i];
        count++;
    }
        
    Console.WriteLine($"Average of positive integers that are multiples of three is {sum / count:F}");
}

void RunFibonacci()
{
    Console.WriteLine("Write size number of fibonacci: ");
    var input = Console.ReadLine();
    if (input == null) return;
    var size = int.Parse(input);

    var fibonacciArr = new int[size];
    fibonacciArr[0] = 1;
    fibonacciArr[1] = 1;
    
    for (int i = 2; i < size; i++)
        fibonacciArr[i] = fibonacciArr[i - 2] + fibonacciArr[i - 1];

    Console.WriteLine("output:");
    for (int i = 0; i < size; i++) Console.WriteLine(fibonacciArr[i]);
}