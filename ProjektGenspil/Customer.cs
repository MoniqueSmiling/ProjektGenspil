using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjektGenspil
{
    public class Customer
    {

        private string _customerId;
        private string _name;
        private string _email;
        private string _phone;

       
        public string CustomerId { get { return _customerId; } set { _customerId = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }


        public List<Reservation> reservations = new List<Reservation>();

        public Customer(string customerId, string name, string email, string phone)
        {
            _customerId = customerId;
            _name = name;
            _email = email;
            _phone = phone;
        }


        public override string ToString()
        {

            return $"{CustomerId}, {Name}, {Email}, {Phone}";
        }


        public static Customer FromString(string data)
        {
            string[] details = data.Split(',');
            string id = (details[0]);
            string name = details[1];
            string email = details[2];
            string phone = details[3];
            //string reservations = details[4];
            // if (details[4] != null)
            return new Customer(id, name, email, phone);
        }



    }
}
