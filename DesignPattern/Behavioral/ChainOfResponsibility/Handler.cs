namespace DesignPattern.Behavioral.ChainOfResponsibility
{
    internal abstract class Handler<T> where T : Person
    {
        protected Dictionary<string, Person> Persons = new()
        {
            { "Salano", new Person("Salano", "Toto1%", "Admin", "EA") },
            { "Monares", new Person("Monares", "Mona1%", "Admin", "US") }
        };

        protected Handler<T>? Successor;

        public abstract void Validate(T request);

        public Handler<T> SetSuccessor(Handler<T> successor)
        {
            Successor = successor;
            return successor;
        }
    }
}