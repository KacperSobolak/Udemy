namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var cfg = new Configuration();
            var cfg = Configuration.GetInstance();
            var cfg2 = Configuration.GetInstance();

            Console.WriteLine(ReferenceEquals(cfg, cfg2));
        }
    }
}
