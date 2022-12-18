namespace AbsractFactory
{
    public interface IIndianRecipe: IRecipe
    {
    }

    public class IndianBasicRecipe : IIndianRecipe
    {
        public void GetRecipe(ICooker cooker)
        {
            cooker.FryRice(200, Level.Strongly);
            cooker.FryChicken(100, Level.Strongly);
            cooker.SaltRice(Level.Strongly);
            cooker.PepperRice(Level.Strongly);
            cooker.PepperChicken(Level.Strongly);
            cooker.SaltChicken(Level.Strongly);
        }
    }

    public class IndianSummerRecipe : IIndianRecipe
    {
        public void GetRecipe(ICooker cooker)
        {
            cooker.FryRice(100, Level.Low);
            cooker.FryChicken(100, Level.Low);
            cooker.SaltRice(Level.None);
            cooker.PepperRice(Level.Medium);
            cooker.PepperChicken(Level.Medium);
            cooker.SaltChicken(Level.None);
        }
    }
}
