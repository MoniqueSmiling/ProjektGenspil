using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjektGenspil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("  ╔══════════════════════════════════════╗");
                Console.WriteLine("  ║       GenSpil  Lagerstyring          ║");
                Console.WriteLine("  ╠══════════════════════════════════════╣");
                Console.WriteLine("  ║                                      ║");
                Console.WriteLine("  ║   1.  Administer spil                ║");
                Console.WriteLine("  ║   2.  Spil oversigt                  ║");
                Console.WriteLine("  ║   3.  Udskriv lagerliste             ║");
                Console.WriteLine("  ║   4.  Reservation                    ║");
                Console.WriteLine("  ║   5.  Kunde reservation              ║");
				Console.WriteLine("  ║                                      ║");
                Console.WriteLine("  ╠══════════════════════════════════════╣");
                Console.WriteLine("  ║   Vælg:                              ║");
                Console.WriteLine("  ╚══════════════════════════════════════╝");
                Console.SetCursorPosition(12, Console.CursorTop - 2);

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        //Kald spilmenu
                        break;
                    case "2":
                        //Oversigt over spil(?)
                        break;
                    case "3":
                        //Udskriv lagerliste
                        break;
                    case "4":
                        //Reservation
                        break;
                    case "5":
                        // kunde reservation
                        break;
				}

			}

            GameHandler gameHandler = new GameHandler(".\\Games.txt");
            CustomerHandler customerHandler = new CustomerHandler(".\\Customers.txt");
            ReservationsHandler reservationHandler = new ReservationsHandler(".\\Reservations.txt");
            InventoryHandler inventoryHandler = new InventoryHandler("\\inventoryGames.txt");

            List<Game> loadedGames = gameHandler.LoadGamesFromFile();
            List<Customer> loadedCustomers = customerHandler.LoadCustomersFromFile();
            List<Reservation> reservations = reservationHandler.LoadReservationsFromFile();

            List<Game> games = new List<Game>()
            {
                new Game("080742094680","Munchkin"),
                new Game("080742094505","Munchkin 2: Unnatural Axe"),
                new Game("080742094710","Munchkin 3: Clerical Errors"),
                new Game("080742094703","Munchkin 4: The Need for Steed"),
                new Game("080742094468","Munchkin 5: De-Ranged"),
            };

            List<Customer> customers = new List<Customer>();
            Customer susan = new Customer("1", "Susan Himmelblå", "susanhimmeblaa@superman.com", "");

            reservations.Add(new Reservation(susan, "080742094468", ReservationState.Reserved));


            customers.Add(susan);


            Game munchkin5 = new Game("080742094468", "Munchkin 5: De-Ranged");
            Inventory inventoryGame = new Inventory(munchkin5, GameCondition.Damaged, InventoryState.Repair, 250);

            foreach (Game game in loadedGames)
            {
                Console.WriteLine(game.ToString());
            }


            foreach (Game customer in loadedGames)
            {
                Console.WriteLine("Game information: " + customer);
            }

            foreach (Customer customer in loadedCustomers)
            {
                foreach (Reservation reservation in reservations)
                    Console.WriteLine("Reservations information:" + reservation.ToString());
            }


            //gameHandler.SaveGamesToFile(games);
            customerHandler.SaveCustomersToFile(customers);




            string reminderMenu = $"""
                ------------------------------------------

                ------------------------------------------
                """;




        }
    }
}
