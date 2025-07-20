using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class AuthorizationHandler : BaseHandler
    {
        private Dictionary<int, int> entityOwners = new()
        {
            { 100, 13 },
            { 101, 14 }
        };

        public AuthorizationHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override void Handle(RequestContext context)
        {
            Console.WriteLine("AuthorizationHandler: Checking user authorization...");

            if (context.Request.UserRole == "Admin")
            {
                _nextHandler.Handle(context);
                return;
            }

            if (entityOwners.TryGetValue(context.Request.UserId, out int ownerId))
            {
                if (ownerId == context.Request.UserId)
                {
                    _nextHandler.Handle(context);
                    return;
                }
            }

            context.Response.IsSuccessful = false;
            context.Response.Message = "Unauthorized access";
        }
    }
}
