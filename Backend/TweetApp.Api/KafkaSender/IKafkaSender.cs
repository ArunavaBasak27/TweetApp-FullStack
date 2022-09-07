namespace TweetApp.Api.KafkaProducer
{
    public interface IKafkaSender
    {
        void Publish(string message);
    }
}
