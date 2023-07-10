class Program
{
    static void Main()
    {
        List<string> games = new List<string>
        {
            "The Legend of Zelda: Breath of the Wild",
            "Final Fantasy VII Remake",
            "Red Dead Redemption 2",
            "God of War",
            "Minecraft",
            "Super Mario Odyssey",
            "Call of Duty: Modern Warfare",
            "Fortnite",
            "Overwatch"
        };


        var orderedGames = games.OrderBy(game => game.Length);


        Console.WriteLine("Ordered Game Names:");
        foreach (var game in orderedGames)
        {
            Console.WriteLine(game);
        }
    }
}
