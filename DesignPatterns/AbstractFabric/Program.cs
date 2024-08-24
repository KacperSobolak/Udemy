namespace AbstractFabric
{
    class Program
    {
        public static void Main(string[] args)
        {
            var uiApplication = new Application(new MacFactory());

            uiApplication.RenderUI();
        }
    }

}