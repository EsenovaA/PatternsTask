using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory.Factories
{
    public class SummerFactory: IFactory
    {
        public IRecipe GetRecipe(Country country)
        {
            switch (country)
            {
                case Country.England:
                    return new EnglandSummerRecipe();
                case Country.India:
                    return new IndianSummerRecipe();
                case Country.Ukraine:
                    return new UkrainianSummerRecipe();
                default:
                    throw new NotSupportedException($"{country} country not supported!");
            }
        }
    }
}
