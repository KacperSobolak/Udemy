namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subscriber1 = new Subscriber("Alice");
            var subscriber2 = new Subscriber("Bob");

            var publisher = new Publisher();

            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);

            publisher.Notify("New update available!");

            publisher.Unsubscribe(subscriber1);

            publisher.Notify("Another update available!");
        }
    }
}
