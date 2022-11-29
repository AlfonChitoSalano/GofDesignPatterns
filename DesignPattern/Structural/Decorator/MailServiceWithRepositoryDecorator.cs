namespace DesignPattern.Structural.Decorator
{
    internal class MailServiceWithRepositoryDecorator : MailServiceDecoratorBase
    {
        private readonly List<string> _messagesSent = new();

        public MailServiceWithRepositoryDecorator(IMailService mailService) : base(mailService)
        {
        }

        public override void SendMail(string message)
        {
            _messagesSent.Add(message);
            base.SendMail(message);
        }

        public void ShowMessagesSent()
        {
            foreach (var message in _messagesSent)
            {
                Console.WriteLine($"Message sent previously: {message}");
            }
        }
    }
}