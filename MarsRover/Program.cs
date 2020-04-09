using MarsRover.Manager;
using MarsRover.Message;
using MarsRover.Model;
using MarsRover.Parser;
using MarsRover.Validation;
using System;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleInputManager inputManager = new ConsoleInputManager();

            UpperRightCoordinateModel upperRightCoordinate = inputManager.Get<UpperRightCoordinateModel>(new UpperRightInputMessage(), new UpperRightInputValidation(), new UpperRightInputParser());

            MarsRoverPositionModel marsRoverPosition = inputManager.Get<MarsRoverPositionModel>(new MarsRoverPositionInputMessage(), new MarsRoverPositionInputValidation(), new MarsRoverPositionInputParser());

            List<char> roverInstructions = inputManager.Get<List<char>>(new RoverInstructionInputMessage(), new RoverInstructionInputValidation(), new RoverInstructionInputParser());

            MarsRoverManager MarsRoverManager = new MarsRoverManager(marsRoverPosition, upperRightCoordinate);

            var result = MarsRoverManager.Run(roverInstructions);

            Console.WriteLine(result.ToString());

            Console.ReadLine();

        }
    }

}
