namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strategy = new CarStrategy();

            var map = new Map(strategy);

            var start = new Cordinate();
            var end = new Cordinate();

            map.CreateRoute(start, end);
        }
    }
}
