using Factory.Models;

namespace Factory
{
    public static class Helper
    {
        public static Trade[] CreateTrades()
        {
            var trades = new List<Trade>();
            trades.Add(new Trade(){ Name = "1", Amount = 15, SubType = TradeSubType.NyOption, Type = TradeType.Future});
            trades.Add(new Trade(){ Name = "2", Amount = 55, SubType = TradeSubType.NyOption, Type = TradeType.Option});
            trades.Add(new Trade(){ Name = "3", Amount = 60, SubType = TradeSubType.NyOption, Type = TradeType.Future});
            trades.Add(new Trade(){ Name = "4", Amount = 110, SubType = TradeSubType.Another, Type = TradeType.Option});
            trades.Add(new Trade(){ Name = "5", Amount = 15, SubType = TradeSubType.NyOption, Type = TradeType.Future});
            trades.Add(new Trade(){ Name = "6", Amount = 30, SubType = TradeSubType.NyOption, Type = TradeType.Future});
            trades.Add(new Trade(){ Name = "7", Amount = 150, SubType = TradeSubType.Another, Type = TradeType.Option});
            trades.Add(new Trade(){ Name = "8", Amount = 65, SubType = TradeSubType.NyOption, Type = TradeType.Option});
            trades.Add(new Trade(){ Name = "9", Amount = 15, SubType = TradeSubType.Another, Type = TradeType.Option});
            trades.Add(new Trade(){ Name = "10", Amount = 25, SubType = TradeSubType.NyOption, Type = TradeType.Future});

            return trades.ToArray();
        }
        
    }
}
