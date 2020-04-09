namespace MarsRover.Message
{
    public class UpperRightInputMessage : IInputMessage
    {
        public string InvalidMessage()
        {
            return "Invalid Input";
        }

        public string GetMessage()
        {
            return "Please write upper-right coordinates of the plateau";

        }
    }
}
