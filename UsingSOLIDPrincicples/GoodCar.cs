namespace UsingSOLIDPrincicples
{
    public class GoodCar
    {
        private IEngine engine;
        public GoodCar(IEngine engine)
        {
            this.engine = engine;
        }

        public void Start()
        {
            engine.Start();
            // and anything else you want the car to do.
            // Range
            // Litres
        }
    }
}
