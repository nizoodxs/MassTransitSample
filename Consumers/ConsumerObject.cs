namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;
    using Microsoft.Extensions.Logging;

    public class ConsumerObject :
        IConsumer<PublisherContract>
    {
        readonly ILogger<ConsumerObject> _logger;

        public ConsumerObject(ILogger<ConsumerObject> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<PublisherContract> context)
        {
            _logger.LogInformation("Recieved value is: {Text}", context.Message.MsgString);
            return Task.CompletedTask;
        }
    }
}