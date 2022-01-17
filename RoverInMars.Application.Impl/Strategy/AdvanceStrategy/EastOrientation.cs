using RoverInMars.Application.Model;
using System;

namespace RoverInMars.Application.Strategy.AdvanceStrategy
{
    public class EastOrientation : BaseOrientation, IAdvance
    {
        protected override void Advance(Coordinates position)
        {
            ++position.Width;
        }

        protected override void Validate(Coordinates position, Coordinates dimensions = null)
        {
            if (position.Width > dimensions.Width)
                throw new Exception("Rover out of the matrix");
            
        }
    }
}