using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Message
{
    public class MarsRoverPositionInputMessage : IInputMessage
    {
        public string GetMessage()
        {
            return "Please write the rover's position";
        }

        public string InvalidMessage()
        {
            return "Invalid input";
        }
    }

}
