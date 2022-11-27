using DesignPattern.Behavioral.ChainOfResponsibility;
using System.ComponentModel.DataAnnotations;

namespace DesignPattern.RunnerOnly
{
    internal class ChainOfResponsibilityProgramRunner : IProgramRunner
    {
        public void Run()
        {           
            var accessHandlerChain = new AuthenticationHandler();
            accessHandlerChain.SetSuccessor(new AuthorizationHandler())
                .SetSuccessor(new RegionalAccessHandler());

            try
            {
                var validPerson = new Person("Salano", "Toto1%", "Admin", "EA");
                accessHandlerChain.Validate(validPerson);
                Console.WriteLine("Person has access.");

                var inValidPerson = new Person("Monares", "Mona1%", "Admin", "US");
                accessHandlerChain.Validate(inValidPerson);
                Console.WriteLine("Person has access.");
            }
            catch (Exception validationException)
            {
                Console.WriteLine(validationException.Message);
            }
        }
    }
}