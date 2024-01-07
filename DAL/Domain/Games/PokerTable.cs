using DAL.Domain.Rules;
using DAL.Domain.Users;

namespace DAL.Domain.Games
{
    public class PokerTable
    {
        public Dictionary<Guid, Player> Players { get; set; }

        public Dictionary<int, Player> Order { get; set; }

        public IRuleSet RuleSet { get; set; }
    }
}
