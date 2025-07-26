namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            context.EjectCard();

            context.InsertCard();
            context.EnterPin(6666);
            context.EnterPin(1234);
            context.WithdrawCash(2000);
            context.InsertCard();
        }
    }
}
