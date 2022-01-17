using RoverInMars.Application.Enum;
using RoverInMars.Application.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Contract
{
    public interface IMissionService
    {
        public MissionResult Start(Coordinates dimensions, Coordinates initialPosition, Orientation initialOrientation, Enum.Movement[] commands);
    }
}
