using System;

namespace testApplication002
{
    class Program
    {
        static void Main(string[] args)
        {
            Games game1 = new Games();
            game1.gameName = "Minecraft";
            game1.gamePrice = 80;
            Games game2 = new Games();
            game2.gameName = "Among Us";
            game2.gamePrice = 8;
            Games game3 = new Games();
            game3.gameName = "Grand Theft Auto V";
            game3.gamePrice = 120;

            Games[] games = new Games[] { game1, game2, game3 };

            for (int s = 0; s < games.Length; s++)
            {
                Console.WriteLine(games[s].gameName + " : " + games[s].gamePrice);
            }

            foreach (var game in games)
            {
                Console.WriteLine(game.gameName + " : " + game.gamePrice);
            }
            int i = 0;

            while (i < games.Length)
            {
                Console.WriteLine(games[i].gameName + " : " + games[i].gamePrice);
                i++;
            }
        }
    }
    class Games
    {
        public string gameName { get; set; }
        public int gamePrice { get; set; }
    }
}