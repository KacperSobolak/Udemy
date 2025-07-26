using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class NoCash : State
    {
        public NoCash(Context context) : base(context)
        {
        }

        public override void InsertCard()
        {
            Console.WriteLine("Card inserted, but no cash available.");
        }

        public override void EjectCard()
        {
            Console.WriteLine("Card ejected.");
            _context.ChangeState(new NoCard(_context));
        }

        public override void EnterPin(int pin)
        {
            Console.WriteLine("No cash available, cannot enter pin.");
        }

        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("Cannot withdraw cash, ATM is out of order.");
        }
    }
}
