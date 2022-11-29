namespace DesignPattern.Structural.Adapter
{
    internal class Workspace
    {
        public string Name { get;  }
        public double GrossFloorArea { get;  }

        public Workspace(string name, double grossFloorArea) 
        { 
            Name = name;
            GrossFloorArea = grossFloorArea;
        }
    }
}
