﻿using System.Collections.Generic;

namespace P03_FootballBetting.Data.Models
{
    public class Team
    {
        public Team()
        {
            this.AwayGames = new HashSet<Game>();
            this.HomeGames = new HashSet<Game>();

            this.Players=new HashSet<Player>();
        }
        public int TeamID { get; set; }

        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public string Initials { get; set; }

        public decimal Budget { get; set; }
        
        public int PrimaryKitColorId { get; set; }

        public virtual Color PrimaryKitColor { get; set; }

        public int SecondaryKitColorId { get; set; }

        public virtual Color SecondaryKitColor { get; set; }

        public int TownId { get; set; }

        public virtual Town Town { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Game> HomeGames { get; set; }

        public virtual ICollection<Game> AwayGames { get; set; }
    }
}