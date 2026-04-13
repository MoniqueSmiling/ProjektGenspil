using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjektGenspil
{
    internal class Reservation
    {
        private int _reservationId;
        private DateTime _reservationTime;
        
        private string _status;

        private Customer _customer; 

        public Reservation(Customer customer, int reservationId, DateTime reserationTime, string Status)
        {
            _customer = customer;
            _reservationId = reservationId;
            _reservationTime = reserationTime;
            _status = Status;
        }



        /*
         public string GenerateUniqueId()
         {
             string finalID = "RE";
             foreach (string word in words)
             {
                 abbreviation += word[0];
             }

             string id = $"{abbreviation}";
             Console.WriteLine(abbreviation);
             return id;
         }
        */
        /*
        public static Reservation FromString(string data) 
        {
            string[] details = data.Split(',');
            string customerId = details[0];
            // Customer ?
            string title = details[1];
            return new Reservation();
        }
        */

    }
}
