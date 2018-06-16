using System;

using TroyCampbell_Blackjack.Models;
using TroyCampbell_Blackjack.Repositories;

namespace TroyCampbell_Blackjack.Services
{
    public class GameService : IGameService
    {
        private IGameRepository gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public Game CreateGame(int numberofDecks, int numberOfPlayers)
        {
            return this.gameRepository.CreateGame(numberofDecks, numberOfPlayers);
        }

        public Deck GetDeck()
        {
            return this.gameRepository.GetDeck();
        }

        public void SaveGame()
        {
            this.gameRepository.SaveGame();
        }
    }
}