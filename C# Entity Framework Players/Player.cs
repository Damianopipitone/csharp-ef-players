using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Entity_Framework_Players
{
    
    public class Player
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; } 

        public int Score { get; set; }

        public int GameNumberPlayed { get; set; }

        public int GameWon { get; set; }

        // COSTRUTTORE

        public Player(string Name, string surname, string Id, int Score, int GameNumberPlayed, int GameWon)
        {
            this.Name = Name;
            this.Surname = surname;
            this.Score = Score;
            this.Id = Id;
            this.GameNumberPlayed = GameNumberPlayed;
            this.GameWon = GameWon;

            
        }

        public override string ToString()
        {
            string rapprsting = "Nome: " + Name + "\n";
            rapprsting += "Cognome: " + Surname + "\n";
            rapprsting += "Id: " + Id + "\n";
            rapprsting += "Punteggio: " + Score + "\n";
            rapprsting += "Partite giocate: " + GameNumberPlayed + "\n";
            rapprsting += "Partite vinte: " + GameWon + "\n";
            return rapprsting;
        }
    }
}
