namespace DesignPattern.Structural.Facade
{
    internal class EmployeeRepositoryService
    {
        private readonly List<string> _employees = new();

        public void Save(string employeeName)
        {
            _employees.Add(employeeName);   
        }

        public void ShowAllUsers()
        {
            foreach (var employee in _employees) 
            {
                Console.WriteLine($"Our employee {employee} is present.");
            }
        }
    }
}
