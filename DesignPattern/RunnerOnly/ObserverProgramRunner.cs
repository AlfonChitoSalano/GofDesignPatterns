using DesignPattern.Behavioral.Observer;

namespace DesignPattern.RunnerOnly
{
    internal class ObserverProgramRunner : IProgramRunner
    {
        public void Run()
        {
            IListener ticketStockService = new TicketStockService();
            IListener ticketResellerService = new TicketResellerService();
            OrderService orderService = new OrderService();

            // add two listeners
            orderService.AddListener(ticketStockService);
            orderService.AddListener(ticketResellerService);

            //updating method
            var newSale = new TicketDetails(1, 200);
            orderService.CompleteTicketSale(newSale);

            //notify listners about state change
            orderService.Notify(newSale);
        }
    }
}
