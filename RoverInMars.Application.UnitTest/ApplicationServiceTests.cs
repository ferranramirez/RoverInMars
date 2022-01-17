using RoverInMars.Application.Contract;
using RoverInMars.Application.Enum;
using RoverInMars.Application.Implementation;
using RoverInMars.Application.Model;
using RoverInMars.Application.Strategy.MovementStrategy;
using Xunit;

namespace RoverInMars.Application.UnitTest
{
    public class ApplicationServiceTests
    {
        private IMissionService _missionService;
        private Coordinates dimensions;

        public ApplicationServiceTests()
        {
            dimensions = new Coordinates(9, 6);
            var _commandFactory = new CommandFactory(dimensions);
            _missionService = new MissionService(_commandFactory);
        }

        [Fact]
        public void StartMission_GivesValidCoordinates_ReturnsValidResult()
        {
            //Arrange            
            var expected = new MissionResult(true, Orientation.E, new Coordinates(5, 2));

            var initialPosition = new Coordinates(3, 3);
            var initialOrientation = Orientation.N;
            var commands = new Movement[]
                {Movement.R, Movement.A, Movement.A, Movement.A, Movement.R, Movement.A, Movement.R, Movement.A, Movement.A, Movement.L, Movement.L, Movement.A};

            //Act
            var actual = _missionService.Start(dimensions, initialPosition, initialOrientation, commands);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartMission_GivesInValidCoordinates_ReturnsInvalidResult()
        {
            //Arrange
            var initialPosition = new Coordinates(3, 3);
            var initialOrientation = Orientation.N;
            var commands = new Movement[]
                { Movement.A, Movement.A, Movement.A, Movement.A, Movement.R, Movement.A, Movement.R, Movement.A, Movement.A, Movement.L, Movement.L, Movement.A};

            //Act
            var actual = _missionService.Start(dimensions, initialPosition, initialOrientation, commands);

            //Assert
            Assert.False(actual.Valid);

        }
    }
}
