using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    internal class WindowsFactory : IUIElementFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
