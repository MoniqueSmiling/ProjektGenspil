using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektGenspil
{
    internal class Datahandler
    {
        

        public string FilePath;

        public Datahandler(string filePath) 
        {
            FilePath = filePath;
        }


        public void SaveGamesToFile(List<Game> games) 
        { 
         
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (Game game in games) 
                {
                    string line;
                    if((line = game.ToString()) != null)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            Console.WriteLine($"{games.Count} spil er gemt i {FilePath}");
        }

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

        public void SaveStockToFile(List<Inventory> inventoryGames) 
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
        public string LoadStockFromFile() 
        { 
            return ""; 
        }

        public void SaveReservationsToFile(List<Reservation> reservations) 
        {
        }
        public string LoadReservationsFromFile() 
        {
            return ""; 
        }


        public void SaveCustomersToFile(List<Customer> customers) 
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (Customer customer in customers)
                {
                    string line;
                    if ((line = customer.ToString()) != null)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            Console.WriteLine($"{customers.Count} kunder er gemt i {FilePath}");

        }
        public List<Customer> LoadCustomersFromFile() 
        {
            List<Customer> customers = new List<Customer>();

            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Ingen fil - starter tomt.");
                return customers;
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
                        customers.Add(Customer.FromString(line));
                    }
                }
            }
            return customers;
        }

    }
}
