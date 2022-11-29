namespace DesignPattern.Structural.Adapter
{
    internal class WorkspaceAdapter : WorkspaceContractDataGetter, IAdapter
    {
        public Workspace GetWorkspace()
        {
            var workSpaceContract = GetWorkspaceContract();

            if (!double.TryParse(workSpaceContract.GrossFloorArea, out var grossFloorArea))
            {
                throw new ArgumentException("error in number conversion");
            }

            return new Workspace(workSpaceContract.Name, grossFloorArea);
        }
    }
}