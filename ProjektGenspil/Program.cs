using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjektGenspil
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Datahandler gameHandler = new Datahandler(".\\Games.txt");
            Datahandler customerHandler = new Datahandler(".\\Customers.txt");
            Datahandler reservationHandler = new Datahandler(".\\Reservations.txt");
            Datahandler inventoryHandler = new Datahandler("\\inventoryGames.txt");

            List<Game> loadedGames = gameHandler.LoadGamesFromFile();
            List<Customer> loadedCustomers = customerHandler.LoadCustomersFromFile();
            // List<Reservation> reservations = reservationHandler.LoadReservationsFromFile();
            /*
            List<Game> games = new List<Game>()
            {
                new Game("080742094680","Munchkin"),
                new Game("080742094505","Munchkin 2: Unnatural Axe"),
                new Game("080742094710","Munchkin 3: Clerical Errors"),
                new Game("080742094703","Munchkin 4: The Need for Steed"),
                new Game("080742094468","Munchkin 5: De-Ranged"),
            };
            */
            List<Customer> customers = new List<Customer>();
            Customer susan = new Customer("1", "Susan Himmelblå", "susanhimmeblaa@superman.com", "");

            List<Reservation> reservations = new List<Reservation>()
            {
                new Reservation(susan, DateTime.Now, "Pending" )
            };
                    
            customers.Add(susan);

            /*
            Game munchkin5 = new Game("080742094468", "Munchkin 5: De-Ranged");
            Inventory inventoryGame = new Inventory(munchkin5);

            foreach (Game game in loadedGames)
            {
                Console.WriteLine(game.ToString());
            }
            */

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer information: " + customer);
            }

            foreach (Customer customer in customers)
            {
                foreach (Reservation reservation in reservations)
                    Console.WriteLine($"Reservation({reservation.ReservationsId}, {reservation.ReservationsTime}, {reservation.Status})");
            }


            //gameHandler.SaveGamesToFile(games);
            customerHandler.SaveCustomersToFile(customers);


         


   
        }
    }
}
