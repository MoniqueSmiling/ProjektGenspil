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

        Customer _customer;

        public string ReservationsId { get; set; }
        public ReservationState ReservationState { get; set; }
        public DateTime ReservationsTime { get; set; }
        public string GameId { get; set; }
        private Inventory _inventoryGame { get; set; }

        public Reservation(Customer customer, string gameId, ReservationState reservationState)
        {
            _customer = customer;
            GameId = gameId;
            ReservationState = reservationState;
            ReservationsTime = DateTime.Now;
            ReservationsId = GenerateUniqueId(ReservationsTime, customer.CustomerId, gameId);
        }

        public Reservation(Customer customer, string gameId, DateTime reservationsTime, ReservationState reservationState)
        {
            _customer = customer;
            GameId = gameId;
            ReservationState = reservationState;
            ReservationsTime = reservationsTime;
            ReservationsId = GenerateUniqueId(ReservationsTime, customer.CustomerId, gameId);
        }

        public string GenerateUniqueId(DateTime reservationsTime, string customerId, string gameId)
         {
             string finalId = $"RE{reservationsTime.ToString("ddMMyy")}{customerId}";
             return finalId;
         }
        

        public override string ToString() => $"{ReservationsId},{GameId},{ReservationsTime.ToString("dd/MM/yyyy")}, {ReservationState}";
        
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
