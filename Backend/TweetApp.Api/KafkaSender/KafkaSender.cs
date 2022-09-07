using Confluent.Kafka;

namespace TweetApp.Api.KafkaProducer
{
    public class KafkaSender : IKafkaSender
    {
        public void Publish(string message)
        {
            using (var producer = new ProducerBuilder<Null, string>(new ProducerConfig { BootstrapServers = "broker:29092" }).Build())
            {
                try
                {
                    Console.WriteLine(producer.ProduceAsync("tweetapp_topic", new Message<Null, string> { Value = message })
                        .GetAwaiter()
                        .GetResult());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Oops, something went wrong: {e}");
                }
            }
        }
    }
}
