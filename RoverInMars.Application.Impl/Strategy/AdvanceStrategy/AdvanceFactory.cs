using RoverInMars.Application.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Strategy.AdvanceStrategy
{
    public class AdvanceFactory
    {
        public IAdvance GetOrientation(Orientation orientationType)
        {
            if (orientationType == Orientation.N)
            {
                return new NorthOrientation();
            }
            else if (orientationType == Orientation.S)
            {
                return new SouthOrientation();
            }
            else if (orientationType == Orientation.E)
            {
                return new EastOrientation();
            }
            else if (orientationType == Orientation.W)
            {
                return new WestOrientation();
            }

            return null;
        }
    }
}
