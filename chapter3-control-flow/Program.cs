RunFibonacci();

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