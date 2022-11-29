namespace DesignPattern.Structural.Adapter
{
    internal class WorkspaceContract
    {
        public string Name { get; }
        public string GrossFloorArea { get; }

        public WorkspaceContract(string name, string grossFloorArea) 
        { 
            Name = name;    
            GrossFloorArea = grossFloorArea;
        }
    }
}
