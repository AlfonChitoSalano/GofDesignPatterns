namespace DesignPattern.Behavioral.Observer
{
    internal interface IListener
    {
        void ReceiveUpdateNotification(TicketDetails ticketDetails);
    }
}
