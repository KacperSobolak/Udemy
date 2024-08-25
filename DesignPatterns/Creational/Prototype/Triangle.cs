using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Triangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render triangle");
        }

        public override Shape ShallowCLone()
        {
            return (Triangle)this.MemberwiseClone();
        }

        public override Shape DeepClone()
        {
            var cloneBase = (Triangle)this.MemberwiseClone();

            cloneBase.Border = new Border
            {
                Color = Border.Color,
                Size = Border.Size
            };

            return cloneBase;
        }
    }
}
