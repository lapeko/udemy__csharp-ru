namespace DefaultNamespace;

public class Top100Players
{
    public static void ShowBestInTop10()
    {
        Console.WriteLine($"Top in top 10: {GetTopAfterBirthYear(10, 1988).FirstOrDefault().ToString()}");
    }
    
    public static void ShowLowestInTop10()
    {
        Console.WriteLine($"Lowest in top 10: {GetTopAfterBirthYear(10, 1988).LastOrDefault().ToString()}");
    }
    
    public static void ShowAverageInTop10()
    {
        Console.WriteLine($"Average in top 10: {GetTopAfterBirthYear(10, 1988)[4].ToString()}");
    }

    public static void ShowsPlayersFromTop100ByCountry(string country)
    {
        GetChessPlayersList()
            .Where(player => player.Country == country)
            .OrderByDescending(player => player.BYear)
            .ToList()
            .ForEach(Console.WriteLine);
    }

    private static IEnumerable<ChessPlayer> GetChessPlayersList()
    {
        return File.ReadAllText("../../../assets/top100.csv")
            .Split("\n")
            .Skip(1)
            .Select(l => new ChessPlayer(l.Split(";")));
    }

    private static List<ChessPlayer> GetTopAfterBirthYear(int numberOfPlayers, int birthYear)
    {
        return GetChessPlayersList()
            // .Where(delegate (ChessPlayer player) { return player.BYear > birthYear; })
            .Where(player => player.BYear > birthYear)
            .Take(numberOfPlayers)
            .ToList();
    }
}

internal class ChessPlayer
{
    private int Rank { get; set; }
    private string Name { get; set; }
    private string Title { get; set; }
    public string Country { get; set; }
    private int Rating { get; set; }
    private int Games { get; set; }
    public int BYear { get; set; }
    
    public ChessPlayer(IReadOnlyList<string> row)
    {
        Rank = int.Parse(row[0]);
        Name = row[1];
        Title = row[2];
        Country = row[3];
        Rating = int.Parse(row[4]);
        Games = int.Parse(row[5]);
        BYear = int.Parse(row[6]);
    }

    public override string ToString()
    {
        return $"rank: {Rank}, name: {Name}, title: {Title}, country: {Country}, rating: {Rating}, games: {Games}, birth year: {BYear}";
    }
}