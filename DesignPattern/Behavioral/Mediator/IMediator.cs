namespace DesignPattern.Behavioral.Mediator
{
    internal interface IMediator
    {
        void Register(Participant participant);
        void Send(string from, string message);
        void Send(string from, string to, string message);
        void SendTo<T>(string from, string message) where T : Participant;
    }
}
