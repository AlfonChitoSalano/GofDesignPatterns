using DesignPattern.Behavioral.Command;

namespace DesignPattern.RunnerOnly
{
    internal class CommandProgramRunner : IProgramRunner
    {
        private readonly Stack<ICommand> _commands = new();

        public void Run()
        {
            IEmployeeManagerRepository repository = new EmployeeManagerRepository();
            ICommand command = new AddEmployeeToManagerListCommand(repository, 1, new Employee(111, "Kevin"));

            if (command.CanExecute())
            {
                command.Execute();
                _commands.Push(command);
            }

            repository.WriteDataStore();

            if (_commands.Any())
            {
                _commands.Pop().Undo();
            }

            repository.WriteDataStore();
        }
    }
}