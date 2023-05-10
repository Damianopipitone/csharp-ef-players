﻿using Microsoft.EntityFrameworkCore;
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
    }
}