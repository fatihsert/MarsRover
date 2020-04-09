namespace MarsRover.Validation
{
    public class MarsRoverPositionInputValidation : IInputValidation
    {
        public bool IsValid(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var splited = input.Split(' ');

            if (splited == null || splited.Length == 0 || splited.Length > 3)
            {
                return false;
            }

            int temp;

            for (int i = 0; i < 1; i++)
            {
                if (!int.TryParse(splited[i], out temp))
                {
                    return false;
                }
            }

            if (int.TryParse(splited[2], out temp))
            {
                return false;
            }

            if (splited[2].Length != 1)
            {
                return false;
            }

            return true;
        }
    }

}
