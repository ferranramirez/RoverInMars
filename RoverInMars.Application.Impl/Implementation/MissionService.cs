using RoverInMars.Application.Contract;
using RoverInMars.Application.Enum;
using RoverInMars.Application.Library.Utils;
using RoverInMars.Application.Model;
using RoverInMars.Application.Strategy.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Implementation
{
    public class MissionService : IMissionService
    {
        private readonly CommandFactory _commandFactory;

        public MissionService(CommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
        }

        public MissionResult Start(Coordinates dimensions, Coordinates initialPosition, Orientation initialOrientation, Enum.Movement[] commands)
        {
            var position = initialPosition;
            var orientationIndex = Array.IndexOf(Constants.CardinalPoints, initialOrientation);
            
            if (orientationIndex == -1) 
                new Exception("The given initial orientation does not exist");

            IMovementCommand actionCommand;

            foreach(var com in commands)
            {
                actionCommand = _commandFactory.GetCommand(com);
               
                try
                {
                    actionCommand.Execute(ref position, ref orientationIndex);
                }
                catch
                {
                    return new MissionResult(false, Constants.CardinalPoints[orientationIndex], position);
                }                    
            }

            return new MissionResult(true, Constants.CardinalPoints[orientationIndex], position);
        }
    }
}
