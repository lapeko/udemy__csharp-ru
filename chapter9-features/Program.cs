using System.Threading.Channels;
using DefaultNamespace;

var list = new List<int>(){1, 2, 3};

var query = list.Where(i => i >= 2); // Where is a deferred method (lazy)
list.Remove(3);

Console.WriteLine(query.Count()); // query is executed here
foreach (var item in query) // query is executed here again
{
    Console.WriteLine(item);
}

list = new List<int>(){1, 2, 3};
query = list.Where(i => i >= 2).ToList(); // ToList is an immediate method (eager)
list.Remove(3);

Console.WriteLine(query.Count()); // query was executed during declaration

Console.WriteLine("----------------------------------------------------------------");
Top100Players.ShowBestInTop10();
Console.WriteLine("----------------------------------------------------------------");
Top100Players.ShowsPlayersFromTop100ByCountry("USA");
