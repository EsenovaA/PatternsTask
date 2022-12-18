using Factory.Models;

namespace Factory
{
    public abstract class TradeFilter
    {
        public abstract IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Country country);
    }
}
