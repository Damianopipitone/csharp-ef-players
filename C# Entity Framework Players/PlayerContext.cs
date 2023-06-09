﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Entity_Framework_Players
{
    public class PlayerContext : DbContext
    {   
        public DbSet<Player> Player { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=PlayerDB;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
