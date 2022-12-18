using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory
{
    public interface IRecipe
    {
        public void GetRecipe(ICooker cooker);
    }
}
