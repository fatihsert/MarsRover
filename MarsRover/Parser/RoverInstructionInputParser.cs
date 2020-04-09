using System.Collections.Generic;

namespace MarsRover.Parser
{
    class RoverInstructionInputParser : IInputParser<List<char>>
    {
        public List<char> Parse(string value)
        {
            List<char> result = new List<char>();

            value = value.ToUpper();

            foreach (var item in value)
            {
                result.Add(item);
            }

            return result;
        }
    }
}
