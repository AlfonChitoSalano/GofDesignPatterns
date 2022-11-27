namespace DesignPattern.Creational.Abstract
{
    internal class PhilippineTaxServiceFactory : ITaxFactory
    {
        public ITaxService CreateTaxService()
        {
            return new PhilippineTaxService();
        }

        public ITaxGoodService CreateTaxGoodService()
        {
            return new PhilippineTaxGoodService();
        }
    }
}
