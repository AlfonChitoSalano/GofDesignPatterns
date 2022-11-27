namespace DesignPattern.Creational.Abstract
{
    internal class AustraliaTaxServiceFactory : ITaxFactory
    {    
        public ITaxService CreateTaxService()
        {
            return new AustraliaTaxService();
        }

        public ITaxGoodService CreateTaxGoodService()
        {
            return new AustraliaTaxGoodService();
        }
    }
}
