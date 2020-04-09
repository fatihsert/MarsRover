using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Message
{
    public interface IInputMessage
    {
        string GetMessage();
        string InvalidMessage();
    }

}
