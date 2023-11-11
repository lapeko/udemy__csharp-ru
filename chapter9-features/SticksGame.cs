namespace chapter9_features;

public class SticksGame
{
    private string? _winner = null;
    private int _sticks;
    private bool _playerTurn;

    public SticksGame(int numberOfSticks = 10)
    {
        _sticks = numberOfSticks;
    }

    public void RunGame()
    {
        _playerTurn = new Random().Next(2) == 1;
        while (_winner is null)
        {
            if (_playerTurn) _playerMove();
            else _computerMove();

            if (_sticks <= 0)
            {
                _winner = _playerTurn ? "Computer" : "Player";
                Console.WriteLine($"{_winner} won!");
            }

            _playerTurn = !_playerTurn;
        }
    }

    private void _computerMove()
    {
        var randomValue = new Random().Next(1, int.Min(3, _sticks) + 1);
        _sticks -= randomValue;
        Console.WriteLine($"Computer move. Taken {randomValue} sticks. {_sticks} sticks left");
    }

    private void _playerMove()
    {
        Console.WriteLine("Your move. Enter number of sticks");
        var sticks = Console.ReadLine();
        if (int.TryParse(sticks, out var sticksValue))
        {
            if (sticksValue < 1 || sticksValue > int.Min(3, _sticks))
            {
                Console.WriteLine("Wrong number of sticks. Try again");
                _playerMove();
            }
            else
            {
                Console.WriteLine($"Your move. {sticksValue} sticks");
                _sticks -= sticksValue;
            }
        }
        else
        {
            Console.WriteLine("Wrong number of sticks. Try again");
            _playerMove();
        }
    }
}