using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory.Factories
{
    public class BasicFactory: IFactory
    {
        public IRecipe GetRecipe(Country country)
        {
            switch (country)
            {
                case Country.England:
                    return new EnglandBasicRecipe();
                case Country.India:
                    return new IndianBasicRecipe();
                case Country.Ukraine:
                    return new UkrainianBasicRecipe();
                default:
                    throw new NotSupportedException($"{country} country not supported!");
            }
        }
    }
}
