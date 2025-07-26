namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var requestContext = new RequestContext
            {
                Request = new Request
                {
                    UserId = 13,
                    UserRole = "Admin",
                    EntityId = 101
                },
                Response = new Response()
            };
             
            IHandler handlerChain = new ValidationHandler(
                new AuthorizationHandler(
                    new ResultHandler(null)));

            handlerChain.Handle(requestContext);

            Console.WriteLine($"IsSuccessful: {requestContext.Response.IsSuccessful}");
            Console.WriteLine($"Message: {requestContext.Response.Message}");
            Console.WriteLine($"Data: {requestContext.Response.Data ?? "No data"}");
        }
    }
}
