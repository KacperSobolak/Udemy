using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Checkbox : Component
    {
        public void Select()
        {
            Console.WriteLine("Checkbox selected");
            _mediator.Notify(this, "select");
        }

        public void Unselect()
        {
            Console.WriteLine("Checkbox unselected");
            _mediator.Notify(this, "unselect");
        }

        public void SaveValue()
        {
            Console.WriteLine("Checkbox value saved");
        }
    }
}
