using MarsRover.Message;
using MarsRover.Parser;
using MarsRover.Validation;
using System;

namespace MarsRover.Manager
{
    public class ConsoleInputManager
    {
        public TModel Get<TModel>(IInputMessage inputMessage, IInputValidation validation, IInputParser<TModel> parser)
            where TModel : class
        {

            var getMessage = inputMessage.GetMessage();

            Console.WriteLine(getMessage);

            string value = Console.ReadLine();

            if (validation.IsValid(value))
            {
                return parser.Parse(value);
            }
            else
            {
                var invalidMessage = inputMessage.InvalidMessage();

                Console.WriteLine(inputMessage);
            }

            return default(TModel);
        }
    }

}
