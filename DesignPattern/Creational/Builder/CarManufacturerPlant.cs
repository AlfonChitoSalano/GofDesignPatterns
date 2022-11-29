namespace DesignPattern.Creational.Builder
{
    internal class CarManufacturerPlant
    {
        private CarBuilder? _builder;

        public void Construct(CarBuilder builder)
        {
            _builder = builder;
            _builder.BuildEngine();
            _builder.BuildFrame();
        }
      
        public void Show()
        {
            Console.WriteLine(_builder?.Car.ToString());
        }
    }
}
