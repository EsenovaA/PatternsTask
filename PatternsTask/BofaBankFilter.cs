using Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class BofaBankFilter : TradeFilter
    {
        public override IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Country country)
        {
            return trades.Where(t => t.Amount > 70).ToArray();
        }
    }
}
