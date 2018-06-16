using Resources.TroyCampbell_Blackjack;
using TroyCampbell_Blackjack.Models.Enums;

namespace TroyCampbell_Blackjack.Models
{
    public class Player
    {
        private PlayerTypes playerType { get; set; }

        public Player(PlayerTypes playerType)
        {
            this.playerType = playerType;
        }

        public Hand Hand { get; set; }

        public string Type()
        {
            string name = string.Empty;

            switch (this.playerType)
            {
                case PlayerTypes.Dealer:
                    name = BlackjackResources.PlayerTypeDealer;
                    break;
                case PlayerTypes.Player:
                    name = BlackjackResources.PlayerTypePlayer;
                    break;
            }

            return name;
        }
    }
}