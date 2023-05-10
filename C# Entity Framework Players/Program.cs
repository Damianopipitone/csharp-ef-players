﻿using C__Entity_Framework_Players;
using System;

using (PlayerContext db  = new PlayerContext())
{
    // CREATE
    Random random = new Random();
    int scoreNumber = random.Next(1, 10);
    int gamePlayedNumber = random.Next(1, 100);
    int gameWonNumber = random.Next(1, gamePlayedNumber +1);

    Player newPlayer = new Player { Name = "Cristiano", Surname = "Ronaldo", Id = "ADG485", Score = scoreNumber, GameNumberPlayed = gamePlayedNumber, GameWon = gameWonNumber };

    db.Add(newPlayer);
    db.SaveChanges();

    List<Player> player = db.Player.OrderBy(player => player.Name).ToList<Player>();

}