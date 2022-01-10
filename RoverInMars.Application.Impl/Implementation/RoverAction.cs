using RoverInMars.Application.Enum;
using RoverInMars.Application.Model;
using RoverInMars.Application.Utils;
using System.Collections.Generic;

namespace RoverInMars.Application.Implementation
{
    public static class RoverAction
    {
        public static bool Advance(ref Coordinates position, int orientationIndex, in Coordinates dimensions)
        {
            var cardinal = Constants.CardinalPoints[orientationIndex];

            if (  cardinal== Orientation.N && (++position.Height > dimensions.Height)
               || cardinal == Orientation.S && (--position.Height > dimensions.Height)
               || cardinal == Orientation.E && (++position.Width > dimensions.Height)
               || cardinal == Orientation.W && (--position.Width > dimensions.Height) )
                return false;

            return true;
        }

        public static void Turn(Command com, ref int orientationIndex)
        {
            if (com == Command.L)
            {
                orientationIndex = (orientationIndex - 1) % 4;
            }
            else if (com == Command.R)
            {
                orientationIndex = (orientationIndex + 1) % 4;
            }
        }
    }
}