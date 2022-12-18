namespace Factory.Factories
{
    public class BarclaysBankFilterFactory : FilterFactory
    {
        protected override TradeFilter CreateFilter()
        {
            return new BarclaysBankFilter();
        }
    }
}
