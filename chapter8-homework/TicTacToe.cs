namespace chapter8_homework;

public class TicTacToe
{
    private readonly int[] _userChoices = new int[9];
    private int _winnerPlayer;
    private int _activePlayer;

    public void Run()
    {
        for (var gameStep = 0; gameStep < 9; gameStep++)
        {
            _activePlayer = gameStep % 2 + 1;
            DrawGameStep();
            HandleInput();
            CheckForWinner();
            if (_winnerPlayer != 0) break;
        }
        PrintGameResult();
    }

    private void DrawGameStep()
    {
        Console.Clear();
        DrawBoard();
        Console.WriteLine($"now player {_activePlayer} is moving");
    }

    private void HandleInput()
    {
        var line = Console.ReadLine();
        var isInt = int.TryParse(line, out var userChoice);
        if (!isInt || userChoice < 0 || userChoice > 8)
        {
            Console.WriteLine("Please enter a box number in range [0, 8]");
            HandleInput();
        }
        else if (_userChoices[userChoice] != 0)
        {
            Console.WriteLine("This box has already been taken");
            HandleInput();
        }
        else _userChoices[userChoice] = _activePlayer;
    }

    private void CheckForWinner()
    {
        int[,] winningCombinations = new int[,]{
            { 0, 1, 2 },
            { 3, 4, 5 },
            { 6, 7, 8 },
            { 0, 3, 6 },
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 0, 4, 8 },
            { 2, 4, 6 },
        };
        for (var i = 0; i < winningCombinations.GetLength(0); i++)
        {
            var matches = 0;
            for (var j = 0; j < winningCombinations.GetLength(1); j++)
            {
                if (_userChoices[winningCombinations[i, j]] == _activePlayer) matches++;
            }
            if (matches == 3)
            {
                _winnerPlayer = _activePlayer;
                return;
            }
        }
    }

    private void PrintGameResult()
    {
        Console.Clear();
        DrawBoard();
        var result = _winnerPlayer == 0 ? "Withdraw" : $"Winner is player: {_winnerPlayer}";
        Console.WriteLine(result);
    }

    private void DrawBoard()
    {
        PrintLine();
        for (var row = 0; row < 3; row++)
        {
            for (var column = 0; column < 3; column++)
            {
                var currentChoice = _userChoices[row * 3 + column];
                var currentLetter = currentChoice switch
                {
                    1 => "X",
                    2 => "0",
                    _ => " "
                };
                Console.Write($"|{currentLetter}");
            }
            Console.WriteLine("|");
            PrintLine();
        }   
    }

    private static void PrintLine()
    {
        Console.WriteLine("+-+-+-+");
    }
}
