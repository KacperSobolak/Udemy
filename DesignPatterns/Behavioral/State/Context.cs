using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Context
    {
        private State _state;
        public int AvailableCash { get; set; } = 2000; 

        public Context()
        {
            _state = new NoCard(this);
        }

        public void ChangeState(State newState)
        {
            _state = newState;
        }

        public void InsertCard()
        {
            _state.InsertCard();
        }

        public void EjectCard()
        {
            _state.EjectCard();
        }

        public void EnterPin(int pin)
        {
            _state.EnterPin(pin);
        }

        public void WithdrawCash(int amount)
        {
            _state.WithdrawCash(amount);
        }
    }
}
