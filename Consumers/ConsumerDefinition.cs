namespace Company.Consumers
{
    using MassTransit;

    public class ConsumerDefinition :
        ConsumerDefinition<ConsumerObject>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<ConsumerObject> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}