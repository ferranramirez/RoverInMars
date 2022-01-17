using RoverInMars.Application.Model;
using System;

namespace RoverInMars.Application.Strategy.AdvanceStrategy
{
    public class SouthOrientation : IAdvance
    {
        public void Execute(Coordinates dimensions, Coordinates position)
        {
            Advance(position);
            Validate(dimensions, position);
        }

        private static void Advance(Coordinates position)
        {
            --position.Height;
        }

        private static void Validate(Coordinates dimensions, Coordinates position)
        {
            if (position.Height < 0)
                throw new Exception("Rover out of the matrix");
        }
    }
}