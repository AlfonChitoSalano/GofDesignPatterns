namespace DesignPattern.Creational.Factory
{
    internal abstract class TaxService
    {
        public abstract int TaxPercentage { get; }

        public override string ToString() => GetType().Name;
    }
}
