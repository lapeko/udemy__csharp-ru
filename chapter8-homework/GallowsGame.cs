using System.Text;

namespace chapter8_homework;

public class GallowsGame
{
    private readonly StringBuilder _hiddenWord = new StringBuilder();
    private string? _guessedWord = null;
    private int _leftAttempts = 5;
    
    public void RunGame()
    {
        SetRandomWord();
        RunGameLoop();
        ShowResult();
    }

    private void SetRandomWord()
    {
        const string path = "./WordsStockRus.txt";
        
        if (!File.Exists(path)) return;
        
        var lines = File.ReadAllLines(path);
        Console.WriteLine($"lines.Length: {lines.Length}");
        _guessedWord = lines[new Random().Next(lines.Length)];
        _hiddenWord.Append(new string('_', _guessedWord.Length));
    }

    private void RunGameLoop()
    {
        if (_guessedWord == null)
        {
            Console.WriteLine("The hidden word can not be generated. Please try to rerun the game.");
            return;
        }

        while (_leftAttempts > 0)
        {
            Console.Clear();
            Console.WriteLine($"Try to guess the word: {_hiddenWord}");
            var letter = GetInputLetter();
            HandleUserInput(letter);
            if (CheckUserWin()) break;
        }
    }

    private void ShowResult()
    {
        var gameStatus = _leftAttempts == 0
            ? $"Maybe you'll be lucky next time"
            : $"You won!";
        var secondLine = $"The guessed word is: {_guessedWord}";
        
        Console.Clear();
        Console.WriteLine($"{gameStatus}\n{secondLine}");
    }

    private char GetInputLetter()
    {
        while (true)
        {
            Console.WriteLine("Enter you letter");
            var res = Console.ReadLine();
            if (res != null) return res[0];
            Console.Clear();
            Console.WriteLine("The input is incorrect.");
        }
    }

    private void HandleUserInput(char userLetter)
    {
        var indexes = FindAllIncludeIndexes(_guessedWord, userLetter);
        foreach (var index in indexes)
            _hiddenWord[index] = userLetter;
        if (indexes.Count == 0) _leftAttempts--;
    }

    private bool CheckUserWin()
    {
        return !(_hiddenWord.ToString().Any(c => c == '_'));
    }

    private static List<int> FindAllIncludeIndexes(string? line, char letter)
    {
        var indexes = new List<int>();
        if (line == null) return indexes;

        for (var i = 0; i < line.Length; i++)
            if (line[i] == letter) indexes.Add(i);

        return indexes;
    }
}