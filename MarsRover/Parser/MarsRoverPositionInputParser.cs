using MarsRover.Model;
using System;

namespace MarsRover.Parser
{
    public class MarsRoverPositionInputParser : IInputParser<MarsRoverPositionModel>
    {
        public MarsRoverPositionModel Parse(string value)
        {
            var splited = value.Split(' ');

            MarsRoverPositionModel marsRoverPosition = new MarsRoverPositionModel();
            marsRoverPosition.X = Convert.ToInt32(splited[0]);
            marsRoverPosition.Y = Convert.ToInt32(splited[1]);
            marsRoverPosition.Head = splited[2].ToUpper()[0];

            return marsRoverPosition;
        }
    }
}
