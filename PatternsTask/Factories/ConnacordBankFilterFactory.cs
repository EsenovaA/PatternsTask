using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public class ConnacordBankFilterFactory : FilterFactory
    {
        protected override TradeFilter CreateFilter()
        {
            return new ConnacordBankFilter();
        }
    }
}
