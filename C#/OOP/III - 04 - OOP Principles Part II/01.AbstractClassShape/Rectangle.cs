﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AbstractClassShape
{
    class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height) { }
        public override int CalculateSurface()
        {
            return height * width / 2;
        }
    }
}
