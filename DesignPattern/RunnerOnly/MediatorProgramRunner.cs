using DesignPattern.Behavioral.Mediator;

namespace DesignPattern.RunnerOnly
{
    internal class MediatorProgramRunner : IProgramRunner
    {
        public void Run()
        {
            var teamChatRoom = new TeamChatRoom();
            var sven = new Lawyer("Sven");
            var ann = new AccountManager("Ann");

            teamChatRoom.Register(sven);
            teamChatRoom.Register(ann);

            ann.Send("Hi everyone, can someone have a look at file ABC123?  I need a compliance check.");
            sven.Send("On it!");
            sven.Send("Ann", "Could you join me in a Teams call?");
        }
    }
}
