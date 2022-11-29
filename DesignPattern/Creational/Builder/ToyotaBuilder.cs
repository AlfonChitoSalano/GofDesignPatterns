namespace DesignPattern.Creational.Builder
{
    internal class ToyotaBuilder : CarBuilder
    {
        public ToyotaBuilder()
            : base("Toyota")
        {
        }

        public override void BuildEngine()
        {
            Car.AddPart("'not a V8'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'4-door only normal'");
        }
    }
}
