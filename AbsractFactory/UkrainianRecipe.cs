using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractFactory
{
    public interface IUkrainianRecipe: IRecipe
    {
    }

    public class UkrainianBasicRecipe : IUkrainianRecipe
    {
        public void GetRecipe(ICooker cooker)
        {
            cooker.FryRice(500, Level.Strongly);
            cooker.FryChicken(300, Level.Medium);
            cooker.SaltRice(Level.Strongly);
            cooker.PepperRice(Level.Low);
            cooker.PepperChicken(Level.Low);
            cooker.SaltChicken(Level.Medium);
        }
    }

    public class UkrainianSummerRecipe : IUkrainianRecipe
    {
        public void GetRecipe(ICooker cooker)
        {
            cooker.FryRice(150, Level.Medium);
            cooker.FryChicken(200, Level.Medium);
            cooker.SaltRice(Level.Low);
            cooker.PepperRice(Level.None);
            cooker.PepperChicken(Level.None);
            cooker.SaltChicken(Level.Low);
        }
    }
}
