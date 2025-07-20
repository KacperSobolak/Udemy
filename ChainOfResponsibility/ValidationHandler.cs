using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class ValidationHandler : BaseHandler
    {
        public ValidationHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override void Handle(RequestContext context)
        {
            Console.WriteLine("ValidationHandler: Validating request...");

            if (context.Request.EntityId > 100)
            {
                _nextHandler.Handle(context);
                return;
            }

            context.Response.IsSuccessful = false;
            context.Response.Message = "Validation failed: Entity ID must be greater than 100.";
        }
    }
}
