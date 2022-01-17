using RoverInMars.Application.Model;
using System;

namespace RoverInMars.Application.Strategy.AdvanceStrategy
{
    public class SouthOrientation : BaseOrientation, IAdvance
    {
        protected override void Advance(Coordinates position)
        {
            --position.Height;
        }

        protected override void Validate(Coordinates position, Coordinates dimensions = null)
        {
            if (position.Height < 0)
                throw new Exception("Rover out of the matrix"); 
        }
    }
}