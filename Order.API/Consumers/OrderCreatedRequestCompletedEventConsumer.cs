using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;
using Order.API.Models;
using Shared.Interfaces;

namespace Order.API.Consumers
{
    public class OrderCreatedRequestCompletedEventConsumer : IConsumer<IOrderCreatedRequestCompletedEvent>
    {
        private readonly AppDbContext _context;

        private readonly ILogger<OrderCreatedRequestCompletedEventConsumer> _logger;

        public OrderCreatedRequestCompletedEventConsumer(AppDbContext context, ILogger<OrderCreatedRequestCompletedEventConsumer> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task Consume(ConsumeContext<IOrderCreatedRequestCompletedEvent> context)
        {
            var order = await _context.Orders.FindAsync(context.Message.OrderId);

            if (order != null)
            {
                order.Status = OrderStatus.Complete;
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Order (Id={context.Message.OrderId}) status changed : {order.Status}");
            }
            else
            {
                _logger.LogError($"Order (Id={context.Message.OrderId}) not found");
            }
        }
    }
}