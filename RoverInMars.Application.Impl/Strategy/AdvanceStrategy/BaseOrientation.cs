using RoverInMars.Application.Model;
using System;

namespace RoverInMars.Application.Strategy.AdvanceStrategy
{
    public abstract class BaseOrientation 
    {
        public void Execute(Coordinates dimensions, Coordinates position)
        {
            Advance(position); 
            Validate(position, dimensions);
        }
        protected abstract void Advance(Coordinates position);
        protected abstract void Validate(Coordinates position, Coordinates dimensions = null);
    }
}