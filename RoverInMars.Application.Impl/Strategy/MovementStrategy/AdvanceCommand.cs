using RoverInMars.Application.Enum;
using RoverInMars.Application.Model;
using RoverInMars.Application.Strategy.AdvanceStrategy;
using RoverInMars.Application.Library.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Strategy.MovementStrategy
{
    public class AdvanceCommand : IMovementCommand
    {
        protected readonly Coordinates _dimensions;
        protected readonly AdvanceFactory _advanceFactory;

        public AdvanceCommand(Coordinates dimensions, AdvanceFactory advanceFactory)
        {
            _dimensions = dimensions;
            _advanceFactory = advanceFactory;
        }

        public void Execute(ref Coordinates position, ref int orientationIndex)
        {
            _advanceFactory.GetOrientation(Constants.CardinalPoints[orientationIndex])
                .Execute(_dimensions, position);
        }
    }
}
