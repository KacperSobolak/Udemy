using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }  
        public Border Border { get; set; }

        public abstract void Render();
        public abstract Shape ShallowCLone();
        public abstract Shape DeepClone();
    }
}
