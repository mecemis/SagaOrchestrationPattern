namespace Shared
{
    public class RabbitMqConstants
    {
        public const string OrderSaga = "order-saga-queue";
        public const string StockRollBackMessageQueueName = "stock-rollback-queue";

        public const string StockReservedEventQueueName = "stock-reserved-queue";

        public const string StockOrderCreatedEventQueueName = "stock-order-created-queue";

        public const string StockPaymentFailedEventQueueName = "stock-payment-failed-queue";

        public const string OrderCreatedRequestCompletedEventQueueName = "order-request-completed-queue";
        public const string OrderCreatedRequestFailedEventQueueName = "order-request-failed-queue";
        public const string OrderPaymentFailedEventQueueName = "order-payment-failed-queue";
        public const string OrderStockNotReservedEventQueueName = "order-stock-not-reserved-queue";

        public const string PaymentStockReservedRequestEventQueueName = "payment-stock-reserved-request-queue";
    }
}