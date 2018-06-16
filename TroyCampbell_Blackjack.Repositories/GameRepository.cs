using System;
using System.Collections.Generic;
using System.Linq;

using TroyCampbell_Blackjack.Models;
using TroyCampbell_Blackjack.Models.Enums;

namespace TroyCampbell_Blackjack.Repositories
{
    public class GameRepository : IGameRepository
    {
        public Game CreateGame(int numberofDecks, int numberOfPlayers)
        {
            return this.InitializeGame(numberofDecks, numberOfPlayers);
        }

        public Deck GetDeck()
        {
            throw new NotImplementedException();
        }

        public void SaveGame()
        {
            throw new NotImplementedException();
        }

        public Card DealCard(Deck deck, CardStates state)
        {
            return deck.Cards.Pop();
        }

        private Deck InitializeDeck(int numberOfDecks)
        {
            var suites = Enum.GetValues(typeof(Suites));
            var ranks = Enum.GetValues(typeof(Ranks));

            List<Card> cards = new List<Card>();

            for (int index = 0; index < numberOfDecks; index++)
            {
                foreach (var suite in suites)
                {
                    foreach (var rank in ranks)
                    {
                        cards.Add(new Card((Suites)suite, (Ranks)rank));
                    }
                }
            }

            return new Deck()
            {
                Cards = new Stack<Card>(cards)
            };
        }

        private Game InitializeGame(int numberofDecks, int numberOfPlayers)
        {
            Deck deck = this.InitializeDeck(numberofDecks);
            deck.Shuffle();

            Game game = new Game
            {
                Deck = deck,
                Dealer = new Player(PlayerTypes.Dealer)
                {
                    Hand = this.InitializeHand(deck, PlayerTypes.Dealer)
                },
                Players = this.InitializePlayers(deck, numberOfPlayers)
            };

            return game;
        }

        private Hand InitializeHand(Deck deck, PlayerTypes playerType)
        {
            Hand hand = new Hand()
            {
                Cards = new List<Card>()
            };

            switch (playerType)
            {
                case PlayerTypes.Dealer:
                    hand.Cards.Add(this.DealCard(deck, CardStates.FaceUp));
                    hand.Cards.Add(this.DealCard(deck, CardStates.FaceDown));
                    break;
            }

            return hand;
        }

        private List<Player> InitializePlayers(Deck deck, int numberOfPlayers)
        {
            List<Player> players = new List<Player>();

            for (int index = 0; index < numberOfPlayers; index++)
            {
                players.Add(new Player(PlayerTypes.Player)
                {
                    Hand = this.InitializeHand(deck, PlayerTypes.Player)
                });
            }

            return players;
        }
    }
}