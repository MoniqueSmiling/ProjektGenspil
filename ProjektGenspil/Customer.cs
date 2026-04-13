using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjektGenspil
{
    internal class Customer
    {

        private int _customerId;
        private string _name;
        private string _email;
        private string _phone;

       
        public int CustomerId { get { return _customerId; } set { _customerId = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }


        public List<Reservation> reservations = new List<Reservation>();

        public Customer(int customerId, string name, string email, string phone)
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
            int id = int.Parse(details[0]);
            string name = details[1];
            string email = details[2];
            string phone = details[3];

            return new Customer(id,name, email, phone);
        }



    }
}
