namespace DesignPattern.Creational.Builder
{
    internal class MaseratiBuilder : CarBuilder
    {
        public MaseratiBuilder()
            : base("Maserati")
        {
        }

        public override void BuildEngine()
        {
            Car.AddPart("'a fancy V8 engine'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'5-door with metallic finish'");
        }
    }
}