using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class CardInserted : State
    {
        public CardInserted(Context context) : base(context)
        {
        }

        public override void InsertCard()
        {
            Console.WriteLine("Card already inserted.");
        }

        public override void EjectCard()
        {
            Console.WriteLine("Card ejected.");
            _context.ChangeState(new NoCard(_context));
        }

        public override void EnterPin(int pin)
        {
            if (pin == 1234) 
            {
                Console.WriteLine("Pin accepted.");
                _context.ChangeState(new PinInserted(_context));
            }
            else
            {
                Console.WriteLine("Incorrect pin. Try again.");
                Console.WriteLine("Card ejected.");
                _context.ChangeState(new NoCard(_context));
            }
        }

        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("Please enter your pin first.");
        }
    }
}
