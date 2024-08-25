using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Rectangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render rectangle");
        }

        public override Shape ShallowCLone()
        {
            return (Rectangle)this.MemberwiseClone();
        }

        public override Shape DeepClone()
        {
            var cloneBase = (Rectangle)this.MemberwiseClone();

            cloneBase.Border = new Border
            {
                Color = Border.Color,
                Size = Border.Size
            };

            return cloneBase;
        }
    }
}
