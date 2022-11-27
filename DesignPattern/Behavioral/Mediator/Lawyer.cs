namespace DesignPattern.Behavioral.Mediator
{
    internal class Lawyer : Participant
    {
        public Lawyer(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write($"{nameof(Lawyer)} {Name} received: ");
            base.Receive(from, message);
        }
    }
}
