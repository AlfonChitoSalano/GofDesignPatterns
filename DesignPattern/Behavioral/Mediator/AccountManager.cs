namespace DesignPattern.Behavioral.Mediator
{
    internal class AccountManager : Participant
    {
        public AccountManager(string name) : base(name)
        {

        }

        public override void Receive(string from, string message)
        {
            Console.Write($"{nameof(AccountManager)} {Name} received: ");
            base.Receive(from, message);
        }
    }
}
