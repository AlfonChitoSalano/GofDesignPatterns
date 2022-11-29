namespace DesignPattern.Structural.Decorator
{
    internal abstract class MailServiceDecoratorBase : IMailService
    {
        private readonly IMailService _mailService;

        protected MailServiceDecoratorBase(IMailService mailService)
        {
            _mailService = mailService;
        }

        public virtual void SendMail(string message)
        {
            _mailService.SendMail(message);
        }
    }
}