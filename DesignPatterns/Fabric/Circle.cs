using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class Circle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render circle");
        }
    }
}
