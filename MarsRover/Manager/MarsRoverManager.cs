using MarsRover.Model;
using System.Collections.Generic;

namespace MarsRover.Manager
{
    public class MarsRoverManager
    {
        // kuzey N ,doğu E,güney S,batı W
        char[] headArray = new char[] { 'N', 'E', 'S', 'W' };
        int _currentHeadIndex = 0;
        int xMax = 5;
        int yMax = 5;
        private int currentHeadIndex
        {
            get
            {
                return _currentHeadIndex;
            }

            set
            {
                _currentHeadIndex = value;

                if (_currentHeadIndex >= headArray.Length || _currentHeadIndex < 0)
                {
                    int mod = _currentHeadIndex % headArray.Length;

                    _currentHeadIndex = mod;

                    if (mod < 0)
                    {
                        _currentHeadIndex += headArray.Length;
                    }
                }
            }
        }

        int _x = 0;
        private int x
        {
            get { return _x; }
            set
            {
                _x = value;

                if (_x > xMax || _x < 0)
                {
                    int mod = _x % xMax;

                    _x = mod;

                    if (mod < 0)
                    {
                        _x += xMax;
                    }
                }

            }

        }

        int _y = 0;
        private int y
        {
            get { return _y; }
            set
            {
                _y = value;

                if (_y > yMax || _y < 0)
                {
                    int mod = _y % yMax;

                    _y = mod;

                    if (mod < 0)
                    {
                        _y += yMax;
                    }
                }
            }

        }

        private int FindHeadIndex(char head)
        {
            for (int i = 0; i < headArray.Length; i++)
            {
                if (headArray[i] == head)
                {
                    return i;
                }
            }

            return -1;
        }

        public MarsRoverManager(MarsRoverPositionModel marsRoverPosition, UpperRightCoordinateModel upperRightCoordinate)
        {
            currentHeadIndex = FindHeadIndex(marsRoverPosition.Head);
            x = marsRoverPosition.X;
            y = marsRoverPosition.Y;

            xMax = upperRightCoordinate.X;
            yMax = upperRightCoordinate.Y;
        }
        public MarsRoverPositionModel Run(List<char> roverInstructions)
        {
            foreach (var roverInstruction in roverInstructions)
            {
                switch (roverInstruction)
                {
                    case 'L':
                        currentHeadIndex -= 1;
                        break;
                    case 'R':
                        currentHeadIndex += 1;
                        break;
                    case 'M':
                        switch (headArray[currentHeadIndex])
                        {
                            case 'N':
                                y += 1;
                                break;
                            case 'E':
                                x += 1;
                                break;
                            case 'S':
                                y -= 1;
                                break;
                            case 'W':
                                x -= 1;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }

            return new MarsRoverPositionModel() { X = x, Y = y, Head = headArray[currentHeadIndex] };
        }
    }
}
