using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektGenspil
{
    public class ReservationsHandler : DataHandler
    {

        public ReservationsHandler(string filePath) : base(filePath) { }

        // ==== RESERVATIONS ====
        // A general overhead of all the outstanding reservations in the system.
        // Uses CustomerId, EAN to check if a game has become available.

        public void SaveReservationsToFile(List<Reservation> reservations)
        {

        }

        // TODO Needs to be List<Reservation> instead of string for return

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
                        //reservations.Add(Reservation.FromString(line));
                    }
                }
            }
            return reservations;
        }
    }
}
    
