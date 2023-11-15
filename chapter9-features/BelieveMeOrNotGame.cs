namespace chapter9_features;

public class BelieveMeOrNotGame
{
    private readonly IEnumerable<Question> _questions;
    private readonly int _allowedCountOfErrors;

    public BelieveMeOrNotGame(int allowedCountOfErrors = 2)
    {
        _allowedCountOfErrors = allowedCountOfErrors;
        _questions = File.ReadAllLines("../../../assets/questions.csv")
            .Select(line => new Question(line));
    }

    public void RunGame()
    {
        var wrongAnswerCount = 0;
        foreach (var question in _questions)
        {
            Console.WriteLine(question.Text);
            Console.WriteLine("Type Y if it is true or N if it is false");
            var answer = Console.ReadLine();

            var isAnswerCorrect = answer is not null && (
                answer.ToLower() == "y" && question.IsTrue ||
                answer.ToLower() == "n" && !question.IsTrue
            );

            if (isAnswerCorrect)
                Console.WriteLine("You are correct !");
            else
            {
                Console.WriteLine($"Wrong. {question.Explanation}");
                wrongAnswerCount++;
            }

            if (wrongAnswerCount > _allowedCountOfErrors) break;
        }

        Console.WriteLine(wrongAnswerCount > _allowedCountOfErrors ? "You lost :(" : "You won !!!");
    }
}

internal class Question
{
    public string Text { get; private set; }
    public bool IsTrue { get; private set; }
    public string Explanation { get; private set; }

    public Question(string line)
    {
        var parts = line.Split(";");
        Text = parts[0];
        IsTrue = parts[1] == "Yes";
        Explanation = parts[2];
    }
}
