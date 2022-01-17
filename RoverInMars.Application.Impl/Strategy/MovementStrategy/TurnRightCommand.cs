using RoverInMars.Application.Enum;
using RoverInMars.Application.Model;
using RoverInMars.Application.Library.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Strategy.MovementStrategy
{
    public class TurnRightCommand : /*CommandFactory, */IMovementCommand
    {
        //protected override IMovementCommand MakeProduct => new AdvanceCommand();

        public void Execute(ref Coordinates position, ref int orientationIndex)
        {
            orientationIndex = (orientationIndex + 1) % 4;
        }
    }
}
