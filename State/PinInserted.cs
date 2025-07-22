using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class PinInserted : State
    {
        public PinInserted(Context context) : base(context)
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
            Console.WriteLine("Pin already entered.");
        }

        public override void WithdrawCash(int amount)
        {
            if (amount > _context.AvailableCash)
            {
                Console.WriteLine("That amount of cash is not available");
                return;
            }

            Console.WriteLine($"Withdrawing {amount} cash.");

            _context.AvailableCash -= amount;


            if (_context.AvailableCash == 0)
            {
                Console.WriteLine("No cash left in ATM.");
                _context.ChangeState(new NoCash(_context));
            }
            else
            {
                Console.WriteLine($"Card ejected");
                _context.ChangeState(new NoCard(_context));
            }
        }
    }
}
