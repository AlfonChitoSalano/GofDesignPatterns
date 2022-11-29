namespace DesignPattern.Structural.Adapter
{
    internal class WorkspaceContractDataGetter
    {
        protected static WorkspaceContract GetWorkspaceContract()
        {
            return new WorkspaceContract("KMC", "10000");
        }
    }
}