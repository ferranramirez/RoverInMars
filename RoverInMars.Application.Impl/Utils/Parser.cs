using RoverInMars.Application.Enum;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace RoverInMars.Application.Utils
{
    public static class Parser
    {
        public static Orientation GetOrientation(string orientation)
        {
            if (orientation.Equals("N")) return Orientation.N;
            if (orientation.Equals("S")) return Orientation.S;
            if (orientation.Equals("E")) return Orientation.E;
            else return Orientation.W;
        }

        public static Command[] GetCommands(string commandLine)
        {
            List<Command> result = new List<Command>();

            foreach(var com in commandLine)
            {
                if (com.Equals('A')) result.Add(Command.A);
                else if (com.Equals('L')) result.Add(Command.L);
                else if (com.Equals('R')) result.Add(Command.R);
            }
            return result.ToArray();
        }
    }
}
