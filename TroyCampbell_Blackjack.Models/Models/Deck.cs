using System;
using System.Collections.Generic;
using System.Linq;

namespace TroyCampbell_Blackjack.Models
{
    public class Deck
    {
        public Stack<Card> Cards { get; set; }

        public void Shuffle()
        {
            List<Card> cards = this.Cards.ToList();
            Random random = new Random();

            int cardCount = cards.Count;
            while (cardCount > 1)
            {
                cardCount--;
                int nextCard = random.Next(cardCount + 1);
                Card card = cards[nextCard];
                cards[nextCard] = cards[cardCount];
                cards[cardCount] = card;
            }

            this.Cards = new Stack<Card>(cards);
        }
    }
}
