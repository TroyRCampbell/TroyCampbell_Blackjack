using TroyCampbell_Blackjack.Models;

namespace TroyCampbell_Blackjack.Repositories
{
    public interface IGameRepository
    {
        Game CreateGame(int numberofDecks, int numberOfPlayers);
        Deck GetDeck();
        void SaveGame();
    }
}