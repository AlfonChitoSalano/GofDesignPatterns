using DesignPattern.Creational.Abstract;

namespace DesignPattern.RunnerOnly
{
    internal class AbstractProgramRunner : IProgramRunner
    {
        public void Run()
        {
            var philippineTax = new Taxes(new PhilippineTaxServiceFactory());
            philippineTax.DisplayTaxes();
            var australiaTax = new Taxes(new AustraliaTaxServiceFactory());
            australiaTax.DisplayTaxes();
        }
    }
}