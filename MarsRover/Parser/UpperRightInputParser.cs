using MarsRover.Model;
using System;

namespace MarsRover.Parser
{
    public class UpperRightInputParser : IInputParser<UpperRightCoordinateModel>
    {
        public UpperRightCoordinateModel Parse(string value)
        {
            string[] splited = value.Split(' ');

            UpperRightCoordinateModel upperRightCoordinate = new UpperRightCoordinateModel();

            upperRightCoordinate.X = Convert.ToInt32(splited[0]);
            upperRightCoordinate.Y = Convert.ToInt32(splited[1]);

            return upperRightCoordinate;
        }
    }

}
