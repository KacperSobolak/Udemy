using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    internal class MacButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Handle mac click");
        }

        public void Render()
        {
            Console.WriteLine("Render mac button");
        }
    }
}
