using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Models
{
    public enum Bank
    {
        Bofa,
        Connacord,
        Barclays,
    }

    public enum TradeType
    {
        Future,
        Option
    }

    public enum TradeSubType
    {
        NyOption,
        Another,
        NewOption
    }

    public enum Country
    {
        USA,
        England,
    }
}
