using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    internal class MacTextBox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine("Handle mac textbox input");
        }

        public void Render()
        {
            Console.WriteLine("Render mac textbox");
        }
    }
}
