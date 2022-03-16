using Shared.Interfaces;

namespace Shared.Events
{
    public class OrderCreatedRequestCompletedEvent : IOrderCreatedRequestCompletedEvent
    {
        public int OrderId { get; set; }
    }
}