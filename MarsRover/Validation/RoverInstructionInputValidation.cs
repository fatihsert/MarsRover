using System;
using System.Linq;

namespace MarsRover.Validation
{
    class RoverInstructionInputValidation : IInputValidation
    {
        public bool IsValid(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            var validArray = new char[] { 'L', 'R', 'M' };

            for (int i = 0; i < input.Length; i++)
            {
                if (!validArray.Contains(input[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
