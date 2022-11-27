namespace DesignPattern.Behavioral.Command
{
    internal class AddEmployeeToManagerListCommand : ICommand
    {
        private readonly IEmployeeManagerRepository _employeeManagerRepository;
        private readonly int _managerId;
        private readonly Employee? _employee;

        public AddEmployeeToManagerListCommand(
            IEmployeeManagerRepository employeeManagerRepository,
            int managerId,
            Employee? employee)
        {
            _employeeManagerRepository = employeeManagerRepository;
            _managerId = managerId;
            _employee = employee;
        }

        public bool CanExecute()
        {
            if (_employee == null)
            {
                return false;
            }

            return !_employeeManagerRepository.HasEmployee(_managerId, _employee.Id);
        }

        public void Execute()
        {
            if (_employee == null)
            {
                return;
            }

            _employeeManagerRepository.AddEmployee(_managerId, _employee);
        }

        public void Undo()
        {
            if (_employee == null)
            {
                return;
            }

            _employeeManagerRepository.RemoveEmployee(_managerId, _employee);
        }
    }
}