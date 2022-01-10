using RoverInMars.Application.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverInMars.Application.Model
{
    public class MissionResult
    {
        public MissionResult(bool valid, Orientation orientation, Coordinates finalCoordinates)
        {
            Valid = valid;
            Orientation = orientation;
            FinalCoordinates = finalCoordinates;
        }

        public bool Valid { get; set; }
        public Orientation Orientation { get; set; }
        public Coordinates FinalCoordinates { get; set; }

        public override bool Equals(object obj)
        {
            return obj is MissionResult result &&
                   Valid == result.Valid &&
                   Orientation == result.Orientation &&
                   EqualityComparer<Coordinates>.Default.Equals(FinalCoordinates, result.FinalCoordinates);
        }
    }
}
