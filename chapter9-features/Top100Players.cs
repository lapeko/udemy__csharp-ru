namespace DefaultNamespace;

public class Top100Players
{
    public void ShowBestInTop10()
    {
        Console.WriteLine($"Top in top 10: {GetRows()[0].ToString()}");
    }
    
    public void ShowLowestInTop10()
    {
        Console.WriteLine($"Lowest in top 10: {GetRows()[9].ToString()}");
    }
    
    public void ShowAverageInTop10()
    {
        Console.WriteLine($"Average in top 10: {GetRows()[4].ToString()}");
    }
    
    private List<ChessPlayer> GetRows()
    {
        return File.ReadAllText("../../../assets/top100.csv")
            .Split("\n")
            .Skip(1)
            .Select(l => new ChessPlayer(l.Split(";")))
            .Where(player => player.BYear > 1988)
            .OrderBy(player => player.Rank)
            .ToList();
    }
}

internal class ChessPlayer
{
    public int Rank { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Country { get; set; }
    public int Rating { get; set; }
    public int Games { get; set; }
    public int BYear { get; set; }
    
    public ChessPlayer(string[] row)
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