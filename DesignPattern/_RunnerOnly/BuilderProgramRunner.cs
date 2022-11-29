using DesignPattern.Creational.Builder;

namespace DesignPattern.RunnerOnly
{
    internal class BuilderProgramRunner : IProgramRunner
    {
        public void Run()
        {
            var maseratiBuilder = new MaseratiBuilder();
            var toyotaBuilder = new ToyotaBuilder();

            var carManufacturer = new CarManufacturerPlant();
            carManufacturer.Construct(toyotaBuilder);
            carManufacturer.Show();
            carManufacturer.Construct(maseratiBuilder);
            carManufacturer.Show();
        }
    }
}