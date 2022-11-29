namespace DesignPattern.Structural.Decorator
{
    internal class MailService : IMailService
    {
        public void SendMail(string message)
        {
            Console.WriteLine($"This message {message} was send via pop3");
        }
    }
}
