using DAL.Domain.Cards;

namespace BLL.Games
{
    public class Player
    {
        public Player(Guid userId, int money)
        {
            UserId = userId;
            Money = money;
        }

        public Guid UserId { get; set; }

        public List<Card> Hand { get; set; } = new List<Card>();

        public List<Card> Table { get; set; } = new List<Card>();

        public int Money { get; set; }
    }
}
