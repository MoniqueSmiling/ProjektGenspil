using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjektGenspil
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Datahandler gameHandler = new Datahandler(".\\Games.txt");
            Datahandler customerHandler = new Datahandler(".\\Customer.txt");
            Datahandler reservationHandler = new Datahandler(".\\Reservations");
            Datahandler inventoryHandler = new Datahandler("\\inventoryGames.txt");
     
            List<Game> loadedGames = gameHandler.LoadGamesFromFile();
            List<Customer> loadedCustomers = customerHandler.LoadCustomersFromFile();
             
            List<Game> games = new List<Game>() 
            {
                new Game("080742094680","Munchkin"),
                new Game("080742094505","Munchkin 2: Unnatural Axe"),
                new Game("080742094710","Munchkin 3: Clerical Errors"),
                new Game("080742094703","Munchkin 4: The Need for Steed"),
                new Game("080742094468","Munchkin 5: De-Ranged"),
            };

            List<Customer> customers = new List<Customer>()
            {
                new Customer( 1, "Susan Himmelblå", "susanhimmeblaa@superman.com", "")
            };


            foreach (Game game in loadedGames)
            {
                Console.WriteLine(game.ToString());
            }

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }

            gameHandler.SaveGamesToFile(games);
            customerHandler.SaveCustomersToFile(customers);


         


   
        }
    }
}
