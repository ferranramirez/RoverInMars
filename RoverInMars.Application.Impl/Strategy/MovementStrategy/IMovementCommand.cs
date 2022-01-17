using RoverInMars.Application.Enum;
using RoverInMars.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Strategy.MovementStrategy
{
    public interface IMovementCommand
    {
        public void Execute(ref Coordinates position, ref int orientationIndex);
    }
}
