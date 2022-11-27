namespace DesignPattern.Creational.Factory
{
    internal class TaxServiceFactory
    {
        public static AustraliaTaxService CreateAustraliaTaxService()
        {
            return new AustraliaTaxService();
        }

        public static PhilippineTaxService CreatePhilippineTaxService()
        {
            return new PhilippineTaxService();
        }
    }
}