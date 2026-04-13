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


        public string ReservationsId;
        public string Status;
        public DateTime ReservationsTime;
 

        public Reservation(Customer customer, DateTime reservationTime, string Status)
        {
            _customer = customer;
            _reservationTime = reservationTime;
            _status = Status;
            _reservationsId = GenerateUniqueId();
        }



        
         public string GenerateUniqueId()
         {
             string finalId = $"RE{_customer.CustomerId}{_reservationTime}";
             /*foreach (string word in words)
             {
                 abbreviation += word[0];
             }
             */
             // string id = $"{abbreviation}";
             // Console.WriteLine(finalId);
             return finalId;
         }
        

        public override string ToString()
        {
            return $"{_reservationsId}, {_reservationTime}, {_status}";
        }
        /*
        public static Reservation FromString(string data)
        {
            string[] details = data.Split(',');
            string reservationsId = details[0];
            DateTime reservationTime = Convert.ToDateTime(details[1]);
            string status = details[2]; // TODO: ReservationState Enum
            return new Reservation(reservationsId, reservationTime, status);
        }
        */



    }
}
