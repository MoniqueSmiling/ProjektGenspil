using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace ProjektGenspil
{
    public class Inventory
    {
        public string UniqueId { get; private set; }
        private Game _game;

        Game InventoryGame {  get; set; }

        public List<Game> _games = new List<Game>();
        public List<Game> _inventoryGames = new List<Game>();
        Dictionary<string, Game> _inventoryGame = new Dictionary<string, Game>();

        public GameCondition GameCondition { get; set; }
        public InventoryState InventoryState { get; set; }
        public double Price { get; set; }


        public Inventory(Game game, GameCondition gameCondition, InventoryState inventoryState, double price) 
        {
            InventoryGame = game;
            UniqueId = GenerateUniqueId();
            GameCondition = gameCondition;
            InventoryState = inventoryState;
            Price = price;
        }


        public string GenerateUniqueId()
        {
            string[] words = InventoryGame.Title.Split(' ');
            string abbreviation = "";
           
            foreach (string word in words)
            {
                abbreviation += word[0];
            }

            string id = $"{abbreviation}{_games.Count()}";
            Console.WriteLine(id);
            return id;
        }

        public void UpdateGame()
        {

        }

        public void SearchGame()
        {

        }
        
        public override string ToString()
        {
            return $"";
        }
        
       /* public static Game FromString(string data)
        {
            string[] details = data.Split(',');
            string title = details[1];
            return new Game();
        }
        */
    }
}
