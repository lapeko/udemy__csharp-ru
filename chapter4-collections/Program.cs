RunDictionary();

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