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
                    if((line = game.ToString()) != null)
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

        // ==== STOCK ====
        // A general overhead of all the games available in the inventory.
        // Uses Games ID.

        // TODO: Not finished.
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


        // ==== RESERVATIONS ====
        // A general overhead of all the outstanding reservations in the system.
        // Uses CustomerId, EAN to check if a game has become available.

        public void SaveReservationsToFile(List<Reservation> reservations) 
        {

        }
        // TODO Needs to be List<Reservation> instead of string for return
        /*
        public List<Reservation> LoadReservationsFromFile() 
        {
            List<Reservation> reservations = new List<Reservation>();

            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Ingen fil - starter tomt.");
                return reservations;
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
                        reservations.Add(Reservation.FromString(line));
                    }
                }
            }
            return customers;
        }

        */
        // ==== CUSTOMERS ====
        // A general overhead of all relevant customer contact information.
        // Used by Reservations.

        /// <summary>
        /// A method that saves customer to  local file Customers.txt.
        /// </summary>
        /// <param name="customers"></param>
        public void SaveCustomersToFile(List<Customer> customers) 
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (Customer customer in customers)
                {
                    foreach (Reservation reservation in customer.reservations)
                        Console.WriteLine($"Reservation({reservation.ReservationsId}, {reservation.ReservationsTime}, {reservation.Status})");
                    string line;
                    if ((line = customer.ToString()) != null)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            Console.WriteLine($"{customers.Count} kunder er gemt i {FilePath}");
        }


        /// <summary>
        /// A method that loads the customers from local file Customers.txt.
        /// </summary>
        /// <returns></returns>
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
                        Console.WriteLine(line);
                        customers.Add(Customer.FromString(line));
                    }
                }
            }
            return customers;
        }
    }
}
