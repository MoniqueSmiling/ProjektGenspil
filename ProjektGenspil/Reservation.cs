using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjektGenspil
{
    public class Reservation
    {
        private string _reservationsId;
        private DateTime _reservationTime;
        
        private string _status;
        private SystemManager _systemManager;


        Customer _customer;

        public string ReservationsId { get; set; }
        public string Status { get; set; }
        public DateTime ReservationsTime { get; set; }
        public string GameId { get; set; } 

        public Reservation(Customer customer, string gameId, string status)
        {
            _customer = customer;
            GameId = gameId;
            Status = status;
            ReservationsTime = DateTime.Now;
            ReservationsId = GenerateUniqueId(ReservationsTime);

        }

        public Reservation(Customer customer, string gameId, DateTime reservationsTime, string status)
        {
            _customer = customer;
            GameId = gameId;
            Status = status;
            ReservationsTime = reservationsTime;
            ReservationsId = GenerateUniqueId(ReservationsTime);

        }




        public string GenerateUniqueId(DateTime reservationsTime)
         {
             string finalId = $"RE{reservationsTime.ToString("ddMMyy")}";
             /*foreach (string word in words)
             {
                 abbreviation += word[0];
             }
             */
             // string id = $"{abbreviation}";
             // Console.WriteLine(finalId);
             return finalId;
         }
        

        public override string ToString() => $"{ReservationsId},{GameId},{ReservationsTime.ToString("dd/MM/yyyy")}, {Status}";
        
        /*
        public static Reservation FromString(string data)
        {
            string[] details = data.Split(',');
            string reservationsId = details[0];
            string gameId = details[1];
            DateTime reservationTime = Convert.ToDateTime(details[1]);
            string status = details[2]; // TODO: ReservationState Enum
            return new Reservation(reservationsId, gameId, reservationTime, status);
        }
        */



    }
}
