using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    internal class WindowsTextBox : ITextBox
    {
        public void HandleInput()
        {
            Console.WriteLine("Handle windows textbox input");
        }

        public void Render()
        {
            Console.WriteLine("Render windows textbox");
        }
    }
}
