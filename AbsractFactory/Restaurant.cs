using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbsractFactory.Factories;

namespace AbsractFactory
{
    public class Restaurant
    {
        public void CookMasala(ICooker cooker, Country country, DateTime currentTime)
        {
            IFactory factory;

            Console.WriteLine($"Current country is {country}");

            if (currentTime.Month >= 5 && currentTime.Month <= 7)
            {
                factory = new SummerFactory();
            }
            else
            {
                factory = new BasicFactory();
            }

            var recipe = factory.GetRecipe(country);
            recipe.GetRecipe(cooker);
        }
    }
}
