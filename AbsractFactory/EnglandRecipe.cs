using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory
{
    public interface IEnglandRecipe: IRecipe
    {
    }

    public class EnglandBasicRecipe : IEnglandRecipe
    {
        public void GetRecipe(ICooker cooker)
        {
            cooker.FryRice(100, Level.Low);
            cooker.FryChicken(100, Level.Low);
            cooker.SaltRice(Level.None);
            cooker.PepperRice(Level.None);
            cooker.PepperChicken(Level.None);
            cooker.SaltChicken(Level.None);
        }
    }

    public class EnglandSummerRecipe : IEnglandRecipe
    {
        public void GetRecipe(ICooker cooker)
        {
            cooker.FryRice(50, Level.Low);
            cooker.FryChicken(50, Level.Low);
            cooker.SaltRice(Level.None);
            cooker.PepperRice(Level.None);
            cooker.PepperChicken(Level.None);
            cooker.SaltChicken(Level.None);
        }
    }
}
