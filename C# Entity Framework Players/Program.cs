using C__Entity_Framework_Players;
using System;

using (PlayerContext db  = new PlayerContext())
{
    try
    {
        // CREATE
        Random random = new Random();
        int scoreNumber = random.Next(1, 10);
        int gamePlayedNumber = random.Next(1, 100);
        int gameWonNumber = random.Next(1, gamePlayedNumber +1);

         Player newPlayer = new Player("Cristiano", "Ronaldo", "AGDGG56", scoreNumber, gamePlayedNumber, gameWonNumber);

        db.Add(newPlayer);
        db.SaveChanges();
        Console.WriteLine(newPlayer.ToString());

        List<Player> player = db.Player.OrderBy(player => player.Name).ToList<Player>();
    } catch (Exception ex)
    {
        Console.WriteLine("Qualcosa è andato storto");
    }
    

}