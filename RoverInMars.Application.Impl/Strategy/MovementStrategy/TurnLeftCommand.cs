using RoverInMars.Application.Enum;
using RoverInMars.Application.Model;
using RoverInMars.Application.Library.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Strategy.MovementStrategy
{
    public class TurnLeftCommand : IMovementCommand
    {
        public void Execute(ref Coordinates position, ref int orientationIndex)
            {
                orientationIndex = (orientationIndex - 1) % 4;
            }
    }
}
