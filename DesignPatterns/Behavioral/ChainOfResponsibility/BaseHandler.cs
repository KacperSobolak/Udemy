using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class BaseHandler : IHandler
    {
        protected IHandler _nextHandler { get; set; }

        protected BaseHandler(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void Handle(RequestContext context);
    }
}
