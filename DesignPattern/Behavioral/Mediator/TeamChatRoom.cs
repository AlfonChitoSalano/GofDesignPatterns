namespace DesignPattern.Behavioral.Mediator
{
    internal class TeamChatRoom : IMediator
    {
        private readonly Dictionary<string, Participant> _teamMembers = new();

        public void Register(Participant participant)
        {
            participant.SetChatroom(this);

            if (!_teamMembers.ContainsKey(participant.Name))
            {
                _teamMembers.Add(participant.Name, participant);
            }
        }

        public void Send(string from, string message)
        {
            foreach (var teamMember in _teamMembers.Values)
            {
                teamMember.Receive(from, message);
            }
        }

        public void Send(string from, string to, string message)
        {
            var teamMember = _teamMembers[to];
            teamMember?.Receive(from, message);
        }

        public void SendTo<T>(string from, string message) where T : Participant
        {
            foreach (var teamMember in _teamMembers.Values.OfType<T>())
            {
                teamMember.Receive(from, message);
            }
        }
    }
}