using RoverInMars.Application.Model;
using System;

namespace RoverInMars.Application.Strategy.AdvanceStrategy
{
    public class EastOrientation : IAdvance
    {
        public void Execute(Coordinates dimensions, Coordinates position)
        {
            Advance(position);
            Validate(dimensions, position);
        }

        private static void Advance(Coordinates position)
        {
            ++position.Width;
        }

        private static void Validate(Coordinates dimensions, Coordinates position)
        {
            if (position.Width > dimensions.Width)
                throw new Exception("Rover out of the matrix");
            
        }
    }
}