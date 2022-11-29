using DesignPattern.Creational.Factory;

namespace DesignPattern.RunnerOnly
{
    internal class FactoryProgramRunner : IProgramRunner
    {
        public void Run()
        {
            //factory
            var taxServices = new List<TaxService>
            {
                TaxServiceFactory.CreateAustraliaTaxService(),
                TaxServiceFactory.CreatePhilippineTaxService()
            };

            foreach (var factory in taxServices)
            {
                Console.WriteLine($"Tax percentage {factory.TaxPercentage} coming from {factory}");
            }
        }
    }
}