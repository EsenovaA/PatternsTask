namespace Factory.Factories
{
    public abstract class FilterFactory
    {
        private TradeFilter _filter { get; set; }

        public FilterFactory()
        {
            _filter = CreateFilter();
        }

        public TradeFilter Filter
        {
            get { return _filter; }
        }


        protected abstract TradeFilter CreateFilter();
    }
}
