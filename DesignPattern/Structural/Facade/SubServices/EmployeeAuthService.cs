namespace DesignPattern.Structural.Facade
{
    internal class EmployeeAuthService
    {
        private readonly Dictionary<string, string> _employeesWithPassword = new()
        {
            { "alfon", "toto1%" },
            { "mona", "mort1%" }
        };

        public bool IsValidLogin(string username, string password)
        {
            if (!_employeesWithPassword.TryGetValue(username, out var passwordValue))
            {
                return false;
            }

            return passwordValue == password;
        }
    }
}