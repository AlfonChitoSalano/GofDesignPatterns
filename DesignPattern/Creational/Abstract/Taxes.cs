namespace DesignPattern.Creational.Abstract
{
    internal class Taxes
    {
        private readonly ITaxGoodService _taxGoodService;
        private readonly ITaxService _taxService;

        public Taxes(ITaxFactory taxFactory)
        {
            _taxService = taxFactory.CreateTaxService();
            _taxGoodService = taxFactory.CreateTaxGoodService();
            Console.WriteLine($"Taxes from {taxFactory.GetType().Name.Replace("TaxServiceFactory", "")}");
        }

        public void DisplayTaxes()
        {
            Console.WriteLine(
                $"Taxes for services {_taxService.TaxPercentage} and taxes for goods {_taxGoodService.TaxOfGoodsPercentage}");
        }
    }
}