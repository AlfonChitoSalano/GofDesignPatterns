using DesignPattern.Structural.Facade;

namespace DesignPattern.RunnerOnly
{
    internal class FacadeProgramRunner : IProgramRunner
    {
        public void Run()
        {
            try
            {
                var employeeFacadeService = new EmployeeFacadeService();
                employeeFacadeService.SaveNewEmployee("alfon", "toto1%", "Wilson New Employee");               
                employeeFacadeService.SaveNewEmployee("Joseph", "toto1%", "Grace New Employee");
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}