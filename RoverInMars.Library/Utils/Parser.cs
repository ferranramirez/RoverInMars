using RoverInMars.Application.Enum;
using System;
using System.Collections.Generic;

namespace RoverInMars.Application.Library.Utils
{
    public static class Parser
    {
        public static Orientation GetOrientation(string orientation)
        {
            if (orientation.Equals("N")) return Orientation.N;
            if (orientation.Equals("S")) return Orientation.S;
            if (orientation.Equals("E")) return Orientation.E;
            if (orientation.Equals("W")) return Orientation.W;
            
            throw new Exception("Wrong Input");
        }

        public static Movement[] GetCommands(string commandLine)
        {
            List<Movement> result = new List<Movement>();

            foreach(var com in commandLine)
            {
                if (com.Equals('A')) result.Add(Movement.A);
                else if (com.Equals('L')) result.Add(Movement.L);
                else if (com.Equals('R')) result.Add(Movement.R);
                else throw new Exception("Wrong Input");
            }
            return result.ToArray();
        }
    }
}
