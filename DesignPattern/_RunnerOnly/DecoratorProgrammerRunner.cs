using DesignPattern.Structural.Decorator;

namespace DesignPattern.RunnerOnly
{
    internal class DecoratorProgrammerRunner : IProgramRunner
    {
        public void Run()
        {
            var mailService = new MailService();
            var mailServiceWithRepo = new MailServiceWithRepositoryDecorator(mailService);
            mailServiceWithRepo.SendMail("Hi Chito, how are you?");
            mailServiceWithRepo.ShowMessagesSent();
            mailServiceWithRepo.SendMail("Hi Chito, I still dont see your response?");
            mailServiceWithRepo.ShowMessagesSent();
        }
    }
}
