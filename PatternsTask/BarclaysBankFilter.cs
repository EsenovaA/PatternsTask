using Factory.Models;

namespace Factory
{
    public class BarclaysBankFilter : TradeFilter
    {
        public override IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Country country)
        {
            switch (country)
            {
                case Country.USA:
                    return trades
                        .Where(t => t.Type == TradeType.Option && t.SubType == TradeSubType.NyOption && t.Amount > 50)
                        .ToArray();

                case Country.England:
                    return trades
                        .Where(t => t.Type == TradeType.Future && t.Amount > 100)
                        .ToArray();
                default:
                    throw new NotSupportedException($"Country {country} not supported for filtering!");
            }
            
        }
    }
}
