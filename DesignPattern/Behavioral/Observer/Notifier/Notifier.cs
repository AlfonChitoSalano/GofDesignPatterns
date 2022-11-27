namespace DesignPattern.Behavioral.Observer
{
    internal abstract class Notifier
    {
        private readonly List<IListener> _listeners = new();

        public void AddListener(IListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(IListener listener)
        {
            _listeners.Remove(listener);
        }

        public void Notify(TicketDetails ticketDetails)
        {
            foreach (var listener in _listeners)
            {
                listener.ReceiveUpdateNotification(ticketDetails);
            }
        }
    }
}