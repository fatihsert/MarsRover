namespace MarsRover.Validation
{
    public class UpperRightInputValidation : IInputValidation
    {
        public bool IsValid(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var splited = input.Split(' ');

            if (splited == null || splited.Length == 0 || splited.Length > 2)
            {
                return false;
            }
            
            int temp;

            for (int i = 0; i < splited.Length; i++)
            {
                if (!int.TryParse(splited[i], out temp))
                {
                    return false;
                }
            }

            return true;
        }
    }

}
