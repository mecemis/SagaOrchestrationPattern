namespace Shared.Interfaces
{
    public interface IOrderCreatedRequestCompletedEvent
    {
        public int OrderId { get; set; }
    }
}