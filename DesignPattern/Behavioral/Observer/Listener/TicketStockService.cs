namespace DesignPattern.Behavioral.Observer
{
    internal class TicketStockService : IListener
    {
        public void ReceiveUpdateNotification(TicketDetails ticketDetails)
        {
            Console.WriteLine($"{nameof(TicketStockService)} notified " +
                $"of ticket change: artist {ticketDetails.ArtistId}, amount {ticketDetails.Amount}");
        }
    }
}
