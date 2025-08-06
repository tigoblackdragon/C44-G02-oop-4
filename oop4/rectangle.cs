using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    /*Q2) Create a class named Rectangle with the following constructors:
    A parameterless constructor that sets the width and height to 0.
    A constructor that accepts width and height as integers.
    A constructor that accepts a single integer and sets both width and height to that value.
    */
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(int side)
        {
            Width = side;
            Height = side;
        }
    }
}
