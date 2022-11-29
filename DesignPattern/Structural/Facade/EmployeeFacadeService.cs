namespace DesignPattern.Structural.Facade
{
    internal class EmployeeFacadeService
    {
        private readonly EmployeeAuthService _employeeAuthService = new();
        private readonly EmployeeRepositoryService _employeeRepositoryService = new();

        public void SaveNewEmployee(string existingUser, string password, string newEmployeeName)
        {
            if (!_employeeAuthService.IsValidLogin(existingUser, password))
            {
                throw new InvalidOperationException("Only existing employees can add new employee");
            }

            _employeeRepositoryService.Save(newEmployeeName);
            _employeeRepositoryService.ShowAllUsers();
        }
    }
}