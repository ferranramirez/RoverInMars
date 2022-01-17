using RoverInMars.Application.Enum;
using RoverInMars.Application.Model;
using RoverInMars.Application.Strategy.AdvanceStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Strategy.MovementStrategy
{
    public class CommandFactory
    {
        private readonly Coordinates _dimensions;
        public CommandFactory(Coordinates dimensions)
        {
            _dimensions = dimensions;
        }

        public IMovementCommand GetCommand(Movement commandType)
        {
            if (commandType == Movement.A)
            {
                var advanceFactory = new AdvanceFactory();
                return new AdvanceCommand(_dimensions, advanceFactory);
            }
            else if (commandType == Movement.L)
            {
                return new TurnLeftCommand();
            }
            else if (commandType == Movement.R)
            {
                return new TurnRightCommand();
            }

            return null;
        }
    }
}
