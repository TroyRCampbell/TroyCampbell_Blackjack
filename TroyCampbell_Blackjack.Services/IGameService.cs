using TroyCampbell_Blackjack.Models;

namespace TroyCampbell_Blackjack.Services
{
    public interface IGameService
    {
        Game CreateGame(int numberofDecks, int numberOfPlayers);
        Deck GetDeck();
        void SaveGame();
    }
}