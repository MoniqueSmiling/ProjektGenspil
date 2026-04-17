using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektGenspil
{
    public class Game
    {
        private int totalCopies;
        private int availableCopies;

        // European Article Number
        public string EAN {  get; private set; }
        public string Title { get; set; }
        
        // Details
        public string Language {get; set; } 
        public DateTime ReleaseYear {get; set; } 
        public int MinPlayers {get; set; } 
        public int MaxPlayers {get; set; }
        // Minutes
        public int PlayTime {get; set; }
        public int MinAge { get; set; }
        public string Description {get; set; }
        

        /// <summary>
        /// Constructor - Quick Game Setup (To use with reservation)
        /// </summary>
        /// <param name="eAN"></param>
        /// <param name="title"></param>
        public Game(string eAN, string title)
        {
            EAN = eAN;
            Title = title;
        }

        /// <summary>
        /// Constructor - Full game information
        /// </summary>
        /// <param name="eAN"></param>
        /// <param name="title"></param>
        /// <param name="language"></param>
        /// <param name="releaseYear"></param>
        /// <param name="minPlayers"></param>
        /// <param name="maxPlayers"></param>
        /// <param name="playTime"></param>
        /// <param name="minAge"></param>
        /// <param name="description"></param>
        public Game(string eAN, string title, string language, 
                    DateTime releaseYear, int minPlayers, int maxPlayers,
                    int playTime, int minAge, string description)
        {
            EAN = eAN;
            Title = title;

            // Details
            Language = language;
            ReleaseYear = releaseYear;
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
            PlayTime = playTime;
            MinAge = minAge;
            Description = description;
        }

        public override string ToString() 
        { 
            return $"{EAN},{Title},{Language},{ReleaseYear.Year},{MinPlayers},{MaxPlayers},{PlayTime},{MinAge},{Description}"; 
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
