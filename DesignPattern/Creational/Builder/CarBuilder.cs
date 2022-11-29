namespace DesignPattern.Creational.Builder
{
    internal abstract class CarBuilder
    {
        public Car Car { get; }

        protected CarBuilder(string carType)
        {
            Car = new Car(carType);
        }

        public abstract void BuildEngine();
        public abstract void BuildFrame();
    }
}
