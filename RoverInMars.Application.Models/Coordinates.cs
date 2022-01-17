using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Model
{
    public class Coordinates
    {
        public Coordinates(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Coordinates coordinates &&
                   Width == coordinates.Width &&
                   Height == coordinates.Height;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Width, Height);
        }
    }
}
