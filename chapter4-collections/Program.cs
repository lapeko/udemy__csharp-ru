﻿RunExoticArrays();

void RunExoticArrays() {
    // Multidimensional
    var multiArr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

    for (var i = 0; i < multiArr.GetLength(0); i++)
    {
        for (var j = 0; j < multiArr.GetLength(1); j++)
            Console.Write(multiArr[i, j] + " ");
        Console.WriteLine();
    }
        
    // RunJagged
    int[][] jaggedArr =
    {
        new int[]{ 1, 2 },
        new int[]{ 3, 4, 5 }
    };
    
    for (var i = 0; i < jaggedArr.Length; i++)
    {
        for (var j = 0; j < jaggedArr[i].Length; j++)
            Console.Write(multiArr[i, j] + " ");
        Console.WriteLine();
    }

    var myArr = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
    myArr.SetValue(1, 1);
    myArr.SetValue(2, 2);
    myArr.SetValue(2, 3);

    Console.WriteLine($"starting index: {myArr.GetLowerBound(0)}");
    Console.WriteLine($"ending index: {myArr.GetUpperBound(0)}");
}

void RunStack()
{
    var stack = new Stack<int>();
    stack.Push(1);
    stack.Push(2);
    stack.Push(3);
    stack.Push(4);
    stack.Push(5);
    stack.Push(6);

    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Peek());
    Console.WriteLine(stack.Peek());

    foreach (var item in stack)
        Console.WriteLine(item);
    
    Console.WriteLine(stack.Peek());
}

void RunQueue()
{
    var queue = new Queue<int>(new int[]{1, 2, 3, 4, 5});
    
    queue.Enqueue(6);
    Console.WriteLine("queue.Dequeue(): " + queue.Dequeue());
    Console.WriteLine("queue.Dequeue(): " + queue.Dequeue());
    Console.WriteLine("queue.Peek(): " + queue.Peek());

    foreach (var item in queue) Console.WriteLine(item);
};

void RunDictionary()
{
    Dictionary<string, DateTime> dict = new Dictionary<string, DateTime>()
    {
        { "Vasya", DateTime.Now.AddYears(-5) },
        { "Anya", DateTime.Now.AddYears(-6).AddMonths(-3) },
    };

    foreach (var pair in dict)
        Console.WriteLine($"{pair.Key} was born at {pair.Value}");
    
    // Will throw an error because of the same key
    // dict.Add("Vasya", DateTime.Now); 
}

void RunArrays()
{
    int[] arr1;
    arr1 = new int[4];
    var arr2 = new int[4] {1, 2, 3, 4};
    int[] arr3 = {1, 2, 4, 5, 7, 8, 10}; // !sorted
    var res = Array.BinarySearch(arr3, 4);
    Console.WriteLine($"Binary search result: {res}");

    var arrCopy = new int[arr3.Length];
    arr3.CopyTo(arrCopy, 0);
    // Array.Copy(arr3, arrCopy, arr3.Length);
    displayArray(arrCopy);

    Array arr4 = Array.CreateInstance(typeof(int), 2);
    arr4.SetValue(1, 0);
    arr4.SetValue(2, 1);
    Console.WriteLine($"arr4.GetValue(0): {arr4.GetValue(0)}");
    Console.WriteLine($"arr4.GetValue(1): {arr4.GetValue(1)}");
}

void displayArray(int[] arr)
{
    Console.WriteLine("========================================");
    foreach (var item in arr) Console.WriteLine(item);
}

