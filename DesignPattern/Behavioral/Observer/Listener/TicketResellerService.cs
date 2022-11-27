namespace DesignPattern.Behavioral.Observer
{
    internal class TicketResellerService : IListener
    {
        public void ReceiveUpdateNotification(TicketDetails ticketDetails)
        {
            Console.WriteLine($"{nameof(TicketResellerService)} notified " +
             $"of ticket change: artist {ticketDetails.ArtistId}, amount {ticketDetails.Amount}");
        }
    }
}
