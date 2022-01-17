using RoverInMars.Application.Model;

namespace RoverInMars.Application.Strategy.AdvanceStrategy
{
    public interface IAdvance
    {
        public void Execute(Coordinates dimensions, Coordinates position);
    }
}