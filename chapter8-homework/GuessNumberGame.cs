namespace chapter8_homework;

public class GuessNumberGame
{
    private static readonly int RandomNumber = new Random().Next(0, 100);
    private static int _attempts = 0;
    private static bool _isNumberGuessed = false;
    
    public static void Run()
    {
        var userStarts = AskUserWantStart();
        Console.WriteLine($"The hidden number is: {RandomNumber}");
        
        if (userStarts)
            RunUserGuessFlow();
        else 
            RunComputerGuessFlow();
    }

    private static bool AskUserWantStart()
    {
        var result = 0;
        
        while (true)
        {
            Console.WriteLine("Choose who will guess the number");
            Console.WriteLine("Press 1 of you are going to guess, press 2 if you want a computer do that");
            var answer = Console.ReadLine();
            
            int.TryParse(answer, out result);

            if (result == 1 || result == 2) break;
            
            Console.WriteLine("You provided incorrect value. It should be 1 or 2");
        }

        return result == 1;
    }

    private static void RunUserGuessFlow()
    {
        while (_attempts++ < 5 && !_isNumberGuessed)
        {
            Console.WriteLine("Enter you number: ");
            var line = Console.ReadLine();
            
            if (int.TryParse(line, out var usersNumber))
            {
                if (usersNumber < 0 || usersNumber > 99)
                {
                    Console.WriteLine("Please, enter a number from 0 to 99");
                    _attempts--;
                    continue;
                }

                if (usersNumber == RandomNumber)
                {
                    _isNumberGuessed = true;
                    break;
                }
                
                Console.WriteLine(usersNumber < RandomNumber
                    ? "The hidden number is higher"
                    : "The hidden number is smaller"
                );
            }
            else
            {
                Console.WriteLine("Please, enter a number from 0 to 99");
                _attempts--;
            };
        }
        Console.WriteLine(_isNumberGuessed
            ? "Your won !!!"
            : "You almost won. Maybe next time you are luck !"
        );
    }
    
    private static void RunComputerGuessFlow()
    {
        var biggest = 99;
        var smallest = 0;
        
        while (_attempts++ < 6 && !_isNumberGuessed)
        {
            Console.WriteLine("Enter you number: ");
            var range = biggest - smallest + 1;
            var computersNumber = smallest + (range - 1) / 2;

            var computersNumberSmaller = computersNumber < RandomNumber;
            if (computersNumberSmaller)
                smallest = computersNumber;
            else
                biggest = computersNumber;
            
            var relation = computersNumberSmaller ? "smaller" : "bigger";
            
            Console.WriteLine($"Computers number is {computersNumber}, which is {relation}");
            
            if (computersNumber == RandomNumber)
            {
                _isNumberGuessed = true;
                break;
            }
        }
        Console.WriteLine(_isNumberGuessed
            ? "Computer won !!!"
            : "Computer almost won. Maybe next time it is luck !"
        );
    }
}