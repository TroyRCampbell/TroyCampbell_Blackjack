using System.Collections.Generic;

namespace TroyCampbell_Blackjack.Models
{
    public class Game
    {
        public Deck Deck { get; set; }
        public Player Dealer { get; set; }
        public List<Player> Players { get; set; }
    }
}
