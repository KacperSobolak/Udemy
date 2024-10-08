﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Circle : Shape
    {
        public int Radius { get; set; }

        public override void Render()
        {
            Console.WriteLine("Render circle");
        }

        public override Shape ShallowCLone()
        {
            return (Circle)this.MemberwiseClone();
        }

        public override Shape DeepClone()
        {
            var cloneBase = (Circle)this.MemberwiseClone();

            cloneBase.Border = new Border
            {
                Color = Border.Color,
                Size = Border.Size
            };

            return cloneBase;
        }
    }
}
