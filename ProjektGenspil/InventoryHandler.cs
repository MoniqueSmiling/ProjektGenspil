using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektGenspil
{
    public class InventoryHandler : DataHandler
    {
        public InventoryHandler(string filePath) : base(filePath) { }


        // ==== INVENTORY ====
        // A general overhead of all the games available in the inventory.
        // Uses Games ID.

        // TODO: Not finished.
        public void SaveInventoryToFile(List<Inventory> inventoryGames)
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (Inventory game in inventoryGames)
                {
                    string line;
                    if ((line = game.ToString()) != null)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            Console.WriteLine($"{inventoryGames.Count} spil er gemt i {FilePath}");
        }


        public string LoadInventoryFromFile()
        {
            return "";
        }

    }

}
