using DesignPattern.Structural.Adapter;

namespace DesignPattern.RunnerOnly
{
    internal class AdapterProgramRunner : IProgramRunner
    {
        public void Run()
        {
            IAdapter adapter = new WorkspaceAdapter();
            var workspace = adapter.GetWorkspace();
            Console.WriteLine(
                $"Our city is {workspace.Name} and its area is in type of {workspace.GrossFloorArea.GetType().Name}");
        }
    }
}