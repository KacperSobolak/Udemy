namespace Observer
{
    internal class Subscriber(string name) : ISubscriber
    {
        public string Name { get; set; } = name;

        public void Update(string context)
        {
            Console.WriteLine($"Subscriber {Name} notified: {context}");
        }
    }
}
