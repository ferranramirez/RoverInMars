using RoverInMars.Application.Contract;
using RoverInMars.Application.Enum;
using RoverInMars.Application.Model;
using RoverInMars.Application.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Implementation
{
    public class MissionService : IMissionService
    {
        public MissionResult Start(Coordinates dimensions, Coordinates initialPosition, Orientation initialOrientation, Command[] commands)
        {
            var valid = true;
            var position = initialPosition;
            var orientationIndex = Array.IndexOf(Constants.CardinalPoints, initialOrientation);

            foreach(var com in commands)
            {
                if(com == Command.A)
                    valid = RoverAction.Advance(ref position, orientationIndex, in dimensions);
                else
                    RoverAction.Turn(com, ref orientationIndex);

                if (!valid) 
                    return new MissionResult(valid, Constants.CardinalPoints[orientationIndex], position);
            }

            return new MissionResult(valid, Constants.CardinalPoints[orientationIndex], position);
        }
    }
}
