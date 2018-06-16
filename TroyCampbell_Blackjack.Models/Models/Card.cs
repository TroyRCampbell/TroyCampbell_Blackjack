using Resources.TroyCampbell_Blackjack;
using TroyCampbell_Blackjack.Models.Enums;

namespace TroyCampbell_Blackjack.Models
{
    public class Card
    {
        private Suites suite { get; set; }
        private Ranks rank { get; set; }
        private CardStates state { get; set; }

        public Card(Suites suite, Ranks rank)
        {
            this.suite = suite;
            this.rank = rank;
        }

        public Card(Suites suite, Ranks rank, CardStates state)
        {
            this.suite = suite;
            this.rank = rank;
            this.state = state;
        }

        public CardStates State { get; private set; }

        public string Suite()
        {
            string name = string.Empty;

            switch(this.suite)
            {
                case Suites.Clubs:
                    name = BlackjackResources.SuiteClubs;
                    break;
                case Suites.Diamonds:
                    name = BlackjackResources.SuiteDiamonds;
                    break;
                case Suites.Hearts:
                    name = BlackjackResources.SuiteHearts;
                    break;
                case Suites.Spades:
                    name = BlackjackResources.SuiteSpades;
                    break;
            }

            return name;
        }

        public string Rank()
        {
            string name = string.Empty;

            switch (this.rank)
            {
                case Ranks.Two:
                    name = BlackjackResources.RankTwo;
                    break;
                case Ranks.Three:
                    name = BlackjackResources.RankThree;
                    break;
                case Ranks.Four:
                    name = BlackjackResources.RankFour;
                    break;
                case Ranks.Five:
                    name = BlackjackResources.RankFive;
                    break;
                case Ranks.Six:
                    name = BlackjackResources.RankSix;
                    break;
                case Ranks.Seven:
                    name = BlackjackResources.RankSeven;
                    break;
                case Ranks.Eight:
                    name = BlackjackResources.RankEight;
                    break;
                case Ranks.Nine:
                    name = BlackjackResources.RankNine;
                    break;
                case Ranks.Ten:
                    name = BlackjackResources.RankTen;
                    break;
                case Ranks.Jack:
                    name = BlackjackResources.RankJack;
                    break;
                case Ranks.Queen:
                    name = BlackjackResources.RankQueen;
                    break;
                case Ranks.King:
                    name = BlackjackResources.RankKing;
                    break;
                case Ranks.Ace:
                    name = BlackjackResources.RankAce;
                    break;
            }

            return name;
        }
    }
}
