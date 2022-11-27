namespace DesignPattern.Behavioral.Observer
{
    internal class TicketDetails
    {
        public int Amount { get; }
        public int ArtistId { get; }

        public TicketDetails(int artistId, int amount)
        {
            ArtistId = artistId;
            Amount = amount;
        }
    }
}
