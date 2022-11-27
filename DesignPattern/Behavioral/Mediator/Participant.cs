namespace DesignPattern.Behavioral.Mediator
{
    internal abstract class Participant
    {
        public string Name { get; }

        private IMediator? _chatroom;

        protected Participant(string name)
        {
            Name = name;
        }

        internal void SetChatroom(IMediator chatRoom)
        {
            _chatroom = chatRoom;
        }

        public void Send(string message)
        {
            _chatroom?.Send(Name, message);
        }

        public void Send(string to, string message)
        {
            _chatroom?.Send(Name, to, message);
        }

        public void SendTo<T>(string message) where T : Participant
        {
            _chatroom?.SendTo<T>(Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"message from {from} to {Name}: {message}");
        }
    }
}