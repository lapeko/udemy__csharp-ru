namespace chapter5_oop;

class RomeNumbers
{
    private static Dictionary<char, int> _romeNumbers = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };

    public static int ConvertToArabic(string romeNumber)
    {
        var calculatedValue = 0;
        var numbers = new int[romeNumber.Length];
        for (int i = 0; i < romeNumber.Length; i++)
            if (_romeNumbers.TryGetValue(romeNumber[i], out int value))
                numbers[i] = value;
            else
                return calculatedValue;

        calculatedValue = numbers[^1];
        for (int i = numbers.Length - 2; i >= 0; i--)
        {
            var currentNum = numbers[i];
            calculatedValue += currentNum > calculatedValue ? currentNum: -currentNum;
        }

        return calculatedValue;
    }
}