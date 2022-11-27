using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    internal class AuthenticationHandler : Handler<Person>
    {       
        public override void Validate(Person request)
        {
            if (request == null) 
            {
                throw new ArgumentNullException(nameof(request));
            }

            var personFound = Persons.FirstOrDefault(x => x.Key == request.Name).Value;

            if (personFound == null)
            {
                throw new ArgumentNullException(nameof(personFound));
            }

            if (request.Password != personFound.Password)
            {
                throw new ValidationException("Password not correct");
            }
            
            Successor?.Validate(request);
        }
    }
}
