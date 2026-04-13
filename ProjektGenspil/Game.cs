using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektGenspil
{
    public class Game
    {
        private int totalCopies;
        private int availableCopies;

        public string EAN {  get; private set; }
        public string Title { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set;}


        public Game(string eAN, string title)
        {
            EAN = eAN;
            Title = title;
        }

        public override string ToString() 
        { 
            return $"{EAN},{Title}"; 
        }

        public static Game FromString(string data) 
        {
            string[] details = data.Split(',');
            string eAN = details[0];
            string title = details[1];
            return new Game(eAN, title); 
        }
    }
}
