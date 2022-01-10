using System;
using RoverInMars.Application;
using RoverInMars.Application.Contract;
using RoverInMars.Application.Enum;
using RoverInMars.Application.Implementation;
using RoverInMars.Application.Model;
using RoverInMars.Application.Utils;

namespace RoverInMars.Presentation.ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            IMissionService _missionService = new MissionService();

            var dimensions = new Coordinates(0, 0);
            var initialPosition = new Coordinates(0, 0);
            Orientation initialOrientation;
            Command[] commands;

            Console.WriteLine("THE ROVER HAS BEEN SENT TO MARS!! Let's start the mission.\n");

            Console.WriteLine("Enter the square dimensions.");
            Console.WriteLine("- Width: ");
            dimensions.Width = int.Parse(Console.ReadLine());
            Console.WriteLine("- Height: ");
            dimensions.Height = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the initial position of the Rover.");
            Console.WriteLine("- Width: ");
            initialPosition.Width = int.Parse(Console.ReadLine());
            Console.WriteLine("- Height: ");
            initialPosition.Height = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the initial orientation of the Rover.");
            Console.WriteLine("- (N, S, E, W): ");
            initialOrientation = Parser.GetOrientation(Console.ReadLine());

            Console.WriteLine("Enter the commands to move the Rover.");
            Console.WriteLine("- (A, L, R): ");
            commands = Parser.GetCommands(Console.ReadLine());

            // Start the mission
            var missionResult = _missionService.Start(dimensions, initialPosition, initialOrientation, commands);

            if (missionResult.Valid)
            {
                Console.WriteLine("\nTHE MISSION WAS SUCCESFULLY COMPLETED!!!");
                Console.WriteLine(string.Concat("- The Rover is now in the position (", missionResult.FinalCoordinates.Width, ", ",
                    missionResult.FinalCoordinates.Height, ")"));
                Console.WriteLine(string.Concat("- And is facing ", missionResult.Orientation.ToString()));
            }
            else
            {
                Console.WriteLine("\nThe Rover got lost in Mars :(");
            }
        }
    }
}
