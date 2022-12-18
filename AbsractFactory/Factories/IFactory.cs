using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory.Factories
{
    public interface IFactory
    {
        public IRecipe GetRecipe(Country country);
    }
}
