using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektGenspil
{
    public class GameHandler : DataHandler
    {
        public GameHandler(string filePath) : base(filePath)
        {
        }

        // ==== GAMES ====
        // A general overhead of all the games and general information logged for future use.


        /// <summary>
        /// A method that saves overall info on games to a local file Games.txt.
        /// </summary>
        /// <param name="games"></param>
        public void SaveGamesToFile(List<Game> games)
        {

            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (Game game in games)
                {
                    string line;
                    if ((line = game.ToString()) != null)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            Console.WriteLine($"{games.Count} spil er gemt i {FilePath}");
        }

        /// <summary>
        /// A method that loads overall info on games to the system from a local file named Games.txt.
        /// </summary>
        /// <param name="games"></param>

        public List<Game> LoadGamesFromFile()
        {
            List<Game> games = new List<Game>();

            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Ingen fil - starter tomt.");
                return games;
            }

            using (StreamReader sr = new StreamReader(FilePath))
            {
                string line;
                // Imens linjen i tekst-filen ikke er nul...
                while ((line = sr.ReadLine()) != null)
                {
                    // ... og den ikke er null eller empty...
                    if (!string.IsNullOrEmpty(line))
                    {
                        games.Add(Game.FromString(line));
                    }
                }
            }
            return games;
        }
    }
}
