namespace MarsRover.Message
{
    class RoverInstructionInputMessage : IInputMessage
    {
        public string GetMessage()
        {
            return "Please   write series of instructions";
        }

        public string InvalidMessage()
        {
            return "Invalid input";
        }
    }
}
