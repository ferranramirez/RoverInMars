using RoverInMars.Application.Model;
using System;

namespace RoverInMars.Application.Strategy.AdvanceStrategy
{
    public class WestOrientation : BaseOrientation, IAdvance
    {
        protected override void Advance(Coordinates position)
        {
            --position.Width;
        }

        protected override void Validate(Coordinates position, Coordinates dimensions = null)
        {
            if (position.Width < 0)
                throw new Exception("Rover out of the matrix");
        }
    }
}