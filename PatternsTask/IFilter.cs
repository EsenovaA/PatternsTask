using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Models;

namespace Factory
{
    public interface IFilter
    {
        IEnumerable<Trade> Match(IEnumerable<Trade> trades);
    }
}
