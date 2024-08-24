using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    internal class WindowsButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Handle windows click");
        }

        public void Render()
        {
            Console.WriteLine("Render windows button");
        }
    }
}
