using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    internal interface ITextBox
    {
        void Render();
        void HandleInput();
    }
}
