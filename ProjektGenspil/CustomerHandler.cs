using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektGenspil
{
    public class CustomerHandler : DataHandler
    {

        public CustomerHandler(string filePath) : base(filePath)
        {
        }
   
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
                        Console.WriteLine($"This is a reservation: Reservation({reservation.ReservationsId} {reservation.ReservationsTime}, {reservation.ReservationState})");
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
