namespace DesignPattern.Creational.Abstract
{
    internal interface ITaxFactory
    {
        ITaxService CreateTaxService();
        ITaxGoodService CreateTaxGoodService();
    }
}
