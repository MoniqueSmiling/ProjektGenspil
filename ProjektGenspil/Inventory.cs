using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ProjektGenspil
{
    public class Inventory
    {
        

        public string UniqueId { get; private set; }
        private Game _game;

        Game inventoryGame {  get; set; }

        public List<Game> _games = new List<Game>();
        Dictionary<string, Game> _inventoryGame = new Dictionary<string, Game>();


        public Inventory(Game game) 
        {
            inventoryGame = game;
            UniqueId = GenerateUniqueId();
        }


        public string GenerateUniqueId()
        {
            string[] words = inventoryGame.Title.Split(' ');
            string abbreviation = "";
            foreach (string word in words)
            {
                abbreviation += word[0];
            }

            string id = $"{abbreviation}";
            Console.WriteLine(abbreviation);
            return id;
        }

        public void AddGame()
        {

        }

        public void SearchGame()
        {

        }
        /*
        public override string ToString()
        {
            return $"";
        }
        
        public static Game FromString(string data)
        {
            string[] details = data.Split(',');
            string title = details[1];
            return new Game(eatitle);
        }
        */
    }
}
