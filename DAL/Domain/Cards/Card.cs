namespace DAL.Domain.Cards
{
    public class Card
    {
        public Card(Rank cardRank, Suit cardSuit)
        {
            CardRank = cardRank;
            CardSuit = cardSuit;
        }

        public Suit CardSuit { get; set; }

        public Rank CardRank { get; set; }
    }
}
