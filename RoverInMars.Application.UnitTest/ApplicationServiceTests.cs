using RoverInMars.Application.Contract;
using RoverInMars.Application.Enum;
using RoverInMars.Application.Implementation;
using RoverInMars.Application.Model;
using Xunit;

namespace RoverInMars.Application.UnitTest
{
    public class ApplicationServiceTests
    {
        private IMissionService _missionService;

        public ApplicationServiceTests()
        {
            _missionService = new MissionService();
        }

        [Fact]
        public void StartMission_GivesValidCoordinates_ReturnsValidResult()
        {
            //Arrange            
            var expected = new MissionResult(true, Orientation.E, new Coordinates(5, 2));

            var dimensions = new Coordinates(9, 6);
            var initialPosition = new Coordinates(3, 3);
            var initialOrientation = Orientation.N;
            var commands = new Command[]
                {Command.R, Command.A, Command.A, Command.A, Command.R, Command.A, Command.R, Command.A, Command.A, Command.L, Command.L, Command.A};

            //Act
            var actual = _missionService.Start(dimensions, initialPosition, initialOrientation, commands);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartMission_GivesInValidCoordinates_ReturnsInvalidResult()
        {
            //Arrange            
            var dimensions = new Coordinates(9, 6);
            var initialPosition = new Coordinates(3, 3);
            var initialOrientation = Orientation.N;
            var commands = new Command[]
                { Command.A, Command.A, Command.A, Command.A, Command.R, Command.A, Command.R, Command.A, Command.A, Command.L, Command.L, Command.A};

            //Act
            var actual = _missionService.Start(dimensions, initialPosition, initialOrientation, commands);

            //Assert
            Assert.False(actual.Valid);

        }
    }
}
