using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Models
{
    public class Trade
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public TradeType Type { get; set; }
        public TradeSubType SubType { get; set; }
    }
}
