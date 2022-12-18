using Factory.Models;

namespace Factory
{
    public class DeutscheBankFilter: TradeFilter
    {
        public override IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Country country)
        {
            return trades
                .Where(t => t.Type == TradeType.Option && t.SubType == TradeSubType.NewOption && t.Amount > 90 && t.Amount < 120)
                .ToArray();
        }
    }
}
