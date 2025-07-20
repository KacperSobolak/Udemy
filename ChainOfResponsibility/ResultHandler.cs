using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler nextHandler) : base(nextHandler)
        {
        }

        public override void Handle(RequestContext context)
        {
            Console.WriteLine("Result handler");

            context.Response.IsSuccessful = true;
            context.Response.Message = "Request processed successfully.";
            context.Response.Data = "Some value";
        }
    }
}
